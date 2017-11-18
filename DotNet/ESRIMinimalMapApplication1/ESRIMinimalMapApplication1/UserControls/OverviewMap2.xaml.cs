/*
Copyright 2013 Esri
Licensed under the Apache License, Version 2.0 (the "License");
You may not use this file except in compliance with the License.
You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using ESRI.ArcGIS.Client;
using ESRI.ArcGIS.Client.Geometry;

namespace ESRI.ArcGIS.SilverlightMapApp
{
    /// <summary>
    /// OverviewMap2 Control
    /// </summary>
    [TemplatePart(Name = "OVMapImage", Type = typeof(Map))]
    [TemplatePart(Name = "AOI", Type = typeof(Grid))]
    [TemplatePart(Name = "MapExtentBorder", Type = typeof(Border))]
    [TemplatePart(Name = "MapDisplayBorder", Type = typeof(Border))]
    [TemplatePart(Name = "MapDisplayEllipse", Type = typeof(Ellipse))]
    [TemplatePart(Name = "AOIprojection", Type = typeof(PlaneProjection))]
    [TemplatePart(Name = "MapProjection", Type = typeof(PlaneProjection))]
    [System.Windows.Markup.ContentProperty("Layer")]
    public class OverviewMap2 : Control
    {
        #region Private fields

        #region Template items
        Map OVMapImage;
        Grid AOI;
        Border MapExtentBorder;
        Border MapDisplayBorder;
        PlaneProjection AOIprojection;
        PlaneProjection MapProjection;
        Ellipse MapDisplayEllipse;

        #endregion

        private Envelope mapExtent;
        private Envelope fullExtent;
        private Envelope lastMapExtent = new Envelope();
        private Envelope lastOVExtent;
        private Point startPoint;
        double offsetLeft = 0;
        double offsetTop = 0;
        private bool dragOn = false;
        private double maxWidth = 0;
        private double maxHeight = 0;
        bool usePlaneProjection = false;
        double marginLRFactor = 0.125;
        double marginTBFactor = 0.25;
        bool showOversize = false;
        double mapAngle = 0;

        #endregion
        public OverviewMap2()
        {
            this.DefaultStyleKey = typeof(OverviewMap2);
        }

        /// <summary>
        /// Static initialization for the <see cref="OverviewMap2"/> control.
        /// </summary>
        static OverviewMap2()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(OverviewMap2),
            //    new FrameworkPropertyMetadata(typeof(OverviewMap2)));
        }
        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code 
        /// or internal processes (such as a rebuilding layout pass) call
        /// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            string strvalue = Application.Current.Resources["UsePlaneProjection"] as string;
            if (strvalue != null)
                usePlaneProjection = bool.Parse(strvalue);
            if (usePlaneProjection)
            {
                strvalue = Application.Current.Resources["MapLeftRightMarginFactor"] as string;
                if (strvalue != null)
                {
                    double val = double.Parse(strvalue, CultureInfo.InvariantCulture);
                    marginLRFactor = val / (1 + (2 * val));
                }
                strvalue = Application.Current.Resources["MapTopBottomMarginFactor"] as string;
                if (strvalue != null)
                {
                    double val = double.Parse(strvalue, CultureInfo.InvariantCulture);
                    marginTBFactor = val / (1 + (2 * val));
                }
            }
            OVMapImage = GetTemplateChild("OVMapImage") as Map;
            if (OVMapImage == null)
            {
                throw new ArgumentNullException("Template child 'OVMapImage' not found");
            }
            OVMapImage.Width = Width;
            OVMapImage.Height = Height;
            OVMapImage.ExtentChanged += (s, e) => { UpdateAOI(); };
            MapExtentBorder = GetTemplateChild("MapExtentBorder") as Border;
            MapDisplayBorder = GetTemplateChild("MapDisplayBorder") as Border;
            AOIprojection = GetTemplateChild("AOIprojection") as PlaneProjection;
            MapProjection = GetTemplateChild("MapProjection") as PlaneProjection;
            MapDisplayEllipse = GetTemplateChild("MapDisplayEllipse") as Ellipse;
            if (this.Layer != null)
                this.OVMapImage.Layers.Add(this.Layer);

            AOI = GetTemplateChild("AOI") as Grid;

            if (AOI != null)
                AOI.MouseLeftButtonDown += AOI_MouseLeftButtonDown;

            UpdateAOI();
        }

        #region Properties

        /// <summary>
        /// Identifies the <see cref="Map"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty MapProperty = DependencyProperty.Register("Map", typeof(Map), typeof(OverviewMap2), new PropertyMetadata(OnMapPropertyChanged));

        private static void OnMapPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OverviewMap2 ovmap = d as OverviewMap2;
            Map oldMap = e.OldValue as Map;
            if (oldMap != null) //clean up
            {
                if (ovmap.OVMapImage != null)
                    ovmap.OVMapImage.Layers.Clear();
                oldMap.ExtentChanged -= ovmap.UpdateOVMap;
            }
            Map newMap = e.NewValue as Map;
            if (newMap != null)
            {
                newMap.ExtentChanged += ovmap.UpdateOVMap;
                if (ovmap.Layer != null && ovmap.OVMapImage != null)
                    ovmap.OVMapImage.Layers.Add(ovmap.Layer);
            }
        }

        /// <summary>
        /// Sets or gets the Map control associated with the OverviewMap.
        /// </summary>
        public Map Map
        {
            get { return (Map)GetValue(MapProperty); }
            set { SetValue(MapProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="MaximumExtent"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty MaximumExtentProperty = DependencyProperty.Register("MaximumExtent", typeof(Envelope), typeof(OverviewMap2), null);

        /// <summary>
        /// Gets or sets  the maximum map extent of the overview map. 
        /// If undefined, the maximum extent is derived from the layer.
        /// </summary>
        /// <value>The maximum extent.</value>
        public Envelope MaximumExtent
        {
            get { return (Envelope)GetValue(MaximumExtentProperty); }
            set { SetValue(MaximumExtentProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="Layer"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty LayerProperty = DependencyProperty.Register("Layer", typeof(Layer), typeof(OverviewMap2), new PropertyMetadata(OnLayerPropertyChanged));

        private static void OnLayerPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OverviewMap2 ovmap = d as OverviewMap2;
            if (ovmap.OVMapImage != null)
            {
                ovmap.OVMapImage.Layers.Clear();
                if (ovmap.Layer != null)
                    ovmap.OVMapImage.Layers.Add(ovmap.Layer);
            }
            if (ovmap.Layer != null)
            {
                bool isInit = ovmap.Layer.IsInitialized;
                if (isInit)
                    ovmap.Layer_LayersInitialized(ovmap.Layer, null);
                else
                    ovmap.Layer.Initialized += ovmap.Layer_LayersInitialized;
            }
        }

        /// <summary>
        /// Gets or sets the layer used in the overview map.
        /// </summary>
        /// <value>The layer.</value>
        public Layer Layer
        {
            get { return (Layer)GetValue(LayerProperty); }
            set { SetValue(LayerProperty, value); }
        }

        /// <summary>
        /// Gets or sets the left/right margin factor used to define size of the MapDisplayBorder in the AOI.
        /// Used for showing difference between actual oversized map extent and area visible in map view when map is not slanted (angle 0).
        /// Only used when UsePlaneProjection is true.
        /// Automatically set if MapLeftRightMarginFactor has been defined in application resources (ResourceDictionary).
        /// Value should be MapLeftRightMarginFactor / (1 + (2 * MapLeftRightMarginFactor)).
        /// Defaults to 0.25, which is proportional to the actual map's negative margin being half of the extent's width or height (0.5).
        /// </summary>
        public double MarginLeftRightFactor { get { return marginLRFactor; } set { marginLRFactor = value; } }
        /// <summary>
        /// Gets or sets the top/bottom margin factor used to define size of the MapDisplayBorder in the AOI.
        /// Used for showing difference between actual oversized map extent and area visible in map view when map is not slanted (angle 0).
        /// Only used when UsePlaneProjection is true.
        /// Automatically set if MapTopBottomMarginFactor has been defined in application resources (ResourceDictionary).
        /// Value should be MapTopBottomMarginFactor / (1 + (2 * MapTopBottomMarginFactor)).
        /// Defaults to 0.25, which is proportional to the actual map's negative margin being half of the extent's width or height (0.5).
        /// </summary>
        public double MarginTopBottomFactor { get { return marginTBFactor; } set { marginTBFactor = value; } }

        /// <summary>
        /// Gets or sets UsePlaneProjection. If true, then map is assumed to be oversized to view to accomondate filling the side edges when the map is slanted.
        /// Automatically set if UsePlaneProjection has been defined in application resources (ResourceDictionary).
        /// Defaults to false.
        /// </summary>
        public bool UsePlaneProjection { get { return usePlaneProjection; } set { usePlaneProjection = value; } }

        public bool ShowOversize
        {
            get { return showOversize; }
            set
            {
                showOversize = value;
                MapExtentBorder.BorderBrush = showOversize ? new SolidColorBrush(Color.FromArgb(102, 51, 51, 51)) : new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
            }
        }

        public double MapAngle { get { return mapAngle; } set { mapAngle = value; if (AOIprojection != null) AOIprojection.RotationX = mapAngle; if (MapProjection != null) MapProjection.RotationX = mapAngle; } }

        public bool UseEllipseAOI
        {
            get { return (bool)GetValue(UseEllipseAOIProperty); }
            set { SetValue(UseEllipseAOIProperty, value); }
        }
        public static readonly DependencyProperty UseEllipseAOIProperty = DependencyProperty.Register("UseEllipseAOI", typeof(bool), typeof(OverviewMap2), new PropertyMetadata(OnUseEllipseAOIPropertyChanged));
        private static void OnUseEllipseAOIPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OverviewMap2 ovmap = d as OverviewMap2;
            if (ovmap.UseEllipseAOI)
            {
                ovmap.MapDisplayEllipse.Visibility = Visibility.Visible;
                ovmap.MapDisplayBorder.Visibility = Visibility.Collapsed;
            }
            else
            {
                ovmap.MapDisplayEllipse.Visibility = Visibility.Collapsed;
                ovmap.MapDisplayBorder.Visibility = Visibility.Visible;

            }
        }


        #endregion

        /// <summary>
        /// Provides the behavior for the "Arrange" pass of Silverlight layout.
        /// Classes can override this method to define their own arrange pass behavior.
        /// </summary>
        /// <param name="finalSize">The final area within the parent that this
        /// object should use to arrange itself and its children.</param>
        /// <returns>The actual size used.</returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            this.Clip = new RectangleGeometry() { Rect = new Rect(0, 0, ActualWidth, ActualHeight) };
            return base.ArrangeOverride(finalSize);
        }

        #region Private Methods

        /// <summary>
        /// Sets extents, limits, and events after layers have been initialized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Layer_LayersInitialized(object sender, EventArgs args)
        {
            fullExtent = OVMapImage.Layers.GetFullExtent();
            OVMapImage.MinimumResolution = double.Epsilon;
            OVMapImage.MaximumResolution = double.MaxValue;
            if (MaximumExtent != null)
            {
                fullExtent = MaximumExtent.Clone();
                maxWidth = fullExtent.Width;
                maxHeight = fullExtent.Height;
                OVMapImage.ZoomTo(fullExtent);
            }
            UpdateOVMap();
        }

        #region Methods for setting extent of OverviewMap

        /// <summary>
        /// Determines if the OverviewMap extent should be changed. If so, set new 
        /// extent and call ZoomTo or PanTo. If not, send to UpdateAOI
        /// </summary>
        private void UpdateOVMap()
        {
            if (Map == null || OVMapImage == null || OVMapImage.Extent == null || Map.Extent == null)
            {
                if (AOI != null)
                    AOI.Visibility = Visibility.Collapsed;
                return;
            }
            // update ov extent if necessary
            double mapWidth = Map.Extent.Width;
            double mapHeight = Map.Extent.Height;
            double ovWidth = OVMapImage.Extent.Width;
            double ovHeight = OVMapImage.Extent.Height;
            double widthRatio = mapWidth / ovWidth;
            double heightRatio = mapHeight / ovHeight;
            double minRatio = 0.15;
            double maxRatio = 0.8;
            Envelope extent;
            bool sameWidthHeight = (mapWidth == lastMapExtent.Width && mapHeight == lastMapExtent.Height);
            if (sameWidthHeight)
            {
                double halfWidth = ovWidth / 2;
                double halfHeight = ovHeight / 2;
                MapPoint newCenter = Map.Extent.GetCenter();
                if (MaximumExtent != null)
                {
                    if (newCenter.X - halfWidth < MaximumExtent.XMin) newCenter.X = MaximumExtent.XMin + halfWidth;
                    if (newCenter.X + halfWidth > MaximumExtent.XMax) newCenter.X = MaximumExtent.XMax - halfWidth;
                    if (newCenter.Y - halfHeight < MaximumExtent.YMin) newCenter.Y = MaximumExtent.YMin + halfHeight;
                    if (newCenter.Y + halfHeight > MaximumExtent.YMax) newCenter.Y = MaximumExtent.YMax - halfHeight;
                }
                if (ovWidth >= maxWidth)
                    UpdateAOI();
                else
                {
                    if (AOI != null)
                        AOI.Visibility = Visibility.Collapsed;
                    OVMapImage.PanTo(newCenter);
                }
            }
            else if (mapWidth >= maxWidth)
                ZoomFullExtent();

            else
            {
                if (widthRatio <= minRatio || heightRatio <= minRatio || widthRatio >= maxRatio || heightRatio >= maxRatio)
                {
                    //set new size around new mapextent
                    if (AOI != null)
                        AOI.Visibility = Visibility.Collapsed;
                    if (maxWidth / 3 > mapWidth)
                    {
                        extent = new Envelope()
                        {
                            XMin = Map.Extent.XMin - mapWidth,
                            XMax = Map.Extent.XMax + mapWidth,
                            YMin = Map.Extent.YMin - mapHeight,
                            YMax = Map.Extent.YMax + mapHeight
                        };
                        if (MaximumExtent != null)
                        {
                            if (extent.XMin < MaximumExtent.XMin) extent.XMin = MaximumExtent.XMin;
                            if (extent.XMax > MaximumExtent.XMax) extent.XMax = MaximumExtent.XMax;
                            if (extent.YMin < MaximumExtent.YMin) extent.YMin = MaximumExtent.YMin;
                            if (extent.YMax > MaximumExtent.YMax) extent.YMax = MaximumExtent.YMax;
                        }
                        OVMapImage.ZoomTo(extent);
                    }
                    else
                        ZoomFullExtent();
                }
                else
                    UpdateAOI();
            }
        }

        /// <summary>
        /// Overload of UpdateOVMap - ExtentEventHandler version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateOVMap(object sender, ESRI.ArcGIS.Client.ExtentEventArgs e)
        {
            UpdateOVMap();
        }

        private void ZoomFullExtent()
        {
            if (lastOVExtent == null)
                OVMapImage.ZoomTo(fullExtent);
            else if (lastOVExtent.Equals(fullExtent))
                UpdateAOI();
            else
                OVMapImage.ZoomTo(fullExtent);
        }

        #endregion

        #region Methods for setting size and position of AOI Box

        /// <summary>
        /// Sets size and position of AOI Box
        /// </summary>
        private void UpdateAOI()
        {
            if (Map == null || OVMapImage == null || OVMapImage.Extent == null || AOI == null) return;
            Envelope extent = Map.Extent;
            if (extent == null)
            {
                AOI.Visibility = Visibility.Collapsed;
                return;
            }
            MapPoint pt1 = new MapPoint(extent.XMin, extent.YMax);
            MapPoint pt2 = new MapPoint(extent.XMax, extent.YMin);
            Point topLeft = OVMapImage.MapToScreen(pt1);
            Point bottomRight = OVMapImage.MapToScreen(pt2);
            if (!double.IsNaN(topLeft.X) && !double.IsNaN(topLeft.Y) &&
                !double.IsNaN(bottomRight.X) && !double.IsNaN(bottomRight.Y))
            {
                AOI.Margin = new Thickness(topLeft.X, topLeft.Y, 0, 0);
                AOI.Width = bottomRight.X - topLeft.X;
                AOI.Height = bottomRight.Y - topLeft.Y;
                AOI.Visibility = Visibility.Visible;
                // the next if added for oversized map using plane projection
                if (usePlaneProjection)
                {
                    double mwidth = AOI.Width * marginLRFactor;
                    double mheight = AOI.Height * marginTBFactor;
                    MapDisplayBorder.Margin = new Thickness(mwidth, mheight - 1, mwidth, mheight + 1);
                    //AOIprojection.RotationX = mapAngle;
                    MapProjection.RotationX = mapAngle;
                }
            }
            else
                AOI.Visibility = Visibility.Collapsed;
            lastMapExtent = extent;
            lastOVExtent = OVMapImage.Extent.Clone();
        }

        #endregion

        #region Method for setting extent of Map

        /// <summary>
        /// Set new map extent of main map control. Called after AOI
        /// Box has been repositioned by user
        /// </summary>
        private void UpdateMap()
        {
            if (AOI == null) return;
            mapExtent = Map.Extent;
            double aoiLeft = AOI.Margin.Left;
            double aoiTop = AOI.Margin.Top;
            MapPoint pt = OVMapImage.ScreenToMap(new Point(aoiLeft, aoiTop));
            double mapHalfWidth = mapExtent.Width / 2;
            double mapHalfHeight = mapExtent.Height / 2;
            MapPoint pnt = new MapPoint(pt.X + mapHalfWidth, pt.Y - mapHalfHeight);
            Map.PanTo(pnt);
        }

        #endregion

        #region AOI Box Mouse handlers
        private void AOI_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dragOn = true;
            startPoint = e.GetPosition(this);
            offsetLeft = startPoint.X - AOI.Margin.Left;
            offsetTop = startPoint.Y - AOI.Margin.Top;
            AOI.MouseMove += AOI_MouseMove;
            AOI.MouseLeftButtonUp += AOI_MouseLeftButtonUp;
            AOI.CaptureMouse();
        }

        private void AOI_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (dragOn)
            {
                AOI.MouseMove -= AOI_MouseMove;
                AOI.MouseLeftButtonUp -= AOI_MouseLeftButtonUp;
                UpdateMap();
                dragOn = false;
                AOI.ReleaseMouseCapture();
            }
        }

        private void AOI_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragOn)
            {
                Point pos = e.GetPosition(this);
                AOI.Margin = new Thickness(pos.X - offsetLeft, pos.Y - offsetTop, 0, 0);
            }
        }

        #endregion

        #endregion


    }
}
