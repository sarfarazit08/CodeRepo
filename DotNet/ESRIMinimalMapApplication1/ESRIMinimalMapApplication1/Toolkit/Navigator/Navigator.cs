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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ESRI.ArcGIS.Client;
using ESRI.ArcGIS.Client.Toolkit;
using Toolkit.Icons;

namespace Toolkit
{
    /// <summary>
    /// Navigator control supporting pan, zoom and rotation.
    /// </summary>
    [TemplatePart(Name = "ResetRotationGrid", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "NavProjection", Type = typeof(PlaneProjection))]
    [TemplatePart(Name = "SlantSlider", Type = typeof(Slider))]
    [TemplatePart(Name = "SlantSliderGrid", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "ZoomGrid_", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "ZoomGridBorder1", Type = typeof(Border))]
    [TemplatePart(Name = "ZoomGridBorder2", Type = typeof(Border))]
    [TemplatePart(Name = "SlantText_", Type = typeof(TextBlock))]
    [TemplatePart(Name = "GlobeGlass", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "ZoomGridStack", Type = typeof(StackPanel))]
    [TemplatePart(Name = "BottomZoomWingUpDownExpand", Type = typeof(UpDownExpand))]
    [TemplatePart(Name = "TopZoomWingUpDownExpand", Type = typeof(UpDownExpand))]
    [TemplatePart(Name = "TopZoomWingCollapseButton", Type = typeof(Button))]
    [TemplatePart(Name = "BottomZoomWingCollapseButton", Type = typeof(Button))]
    [TemplatePart(Name = "ExpandZoomBar", Type = typeof(Storyboard))]
    [TemplatePart(Name = "ShrinkZoomBar", Type = typeof(Storyboard))]
    [TemplatePart(Name = "ExpandProgressBarSpacer", Type = typeof(Storyboard))]
    [TemplatePart(Name = "ShrinkProgressBarSpacer", Type = typeof(Storyboard))]
    [TemplatePart(Name = "ProgressBarSpacer", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "ScaleBarBlock", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "PaddingLeftForScaleBarTextMeters", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "PaddingLeftTopNotch", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "PaddingLeftForScaleBarTextMiles", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "PaddingLeftBottomNotch", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "ScaleLine", Type = typeof(ScaleLine))]
    [TemplatePart(Name = "root", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "NavOpacitySliderGrid", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "NavOpacitySlider", Type = typeof(Slider))]
    [TemplatePart(Name = "OpacityText", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "progressBarGrid", Type = typeof(FrameworkElement))]
    [TemplatePart(Name = "ScaleBarInnerBorder", Type = typeof(Border))]
    [TemplatePart(Name = "ScaleBarWingCollapseButton", Type = typeof(Button))]
    [TemplatePart(Name = "ScaleBarWingCollapseImage", Type = typeof(Image))]
    [TemplatePart(Name = "ScaleBarOuterBorder", Type = typeof(Border))]
    [TemplatePart(Name = "progressBar", Type = typeof(MapProgressBar))]
    [TemplatePart(Name = "ScaleBarWingLeftRightExpand", Type = typeof(LeftRightExpand))]
    public class Navigator : Navigation
    {
        #region private fields

        FrameworkElement ResetRotationGrid;
        ScaleLine ScaleLine;
        FrameworkElement root;
        FrameworkElement NavOpacitySliderGrid;
        Slider NavOpacitySlider;
        FrameworkElement OpacityText;
        FrameworkElement progressBarGrid;
        Border ScaleBarInnerBorder;
        Button ScaleBarWingCollapseButton;
        Border ScaleBarOuterBorder;
        MapProgressBar progressBar;

        SolidColorBrush levelGreaterThanBrush;
        SolidColorBrush levelLessThanBrush;
        SolidColorBrush levelEqualsBrush;

        PlaneProjection NavProjection;
        Slider SlantSlider;
        FrameworkElement SlantSliderGrid;
        Border NavCircle;
        FrameworkElement ZoomGrid;
        Border ZoomGridOuterBorder;
        Border ZoomGridInnerBorder;
        TextBlock SlantText;
        FrameworkElement SlantGlass;
        StackPanel ZoomGridStack;
        UpDownExpand BottomZoomWingUpDownExpand;
        UpDownExpand TopZoomWingUpDownExpand;
        Button TopZoomCollapseButton;
        Button BottomZoomCollapseButton;
        Storyboard ExpandZoomBar;
        Storyboard ShrinkZoomBar;
        Storyboard ExpandProgressBarSpacer;
        Storyboard ShrinkProgressBarSpacer;
        LeftRightExpand ScaleBarWingLeftRightExpand;

        Navigator navControl;
        Point startPoint;
        double lastY = 0;
        bool bottomAligned = false;
        bool usePlaneProjection = false;
        double mapAngle = 0;

        public PlaneProjection MapProjection { get; set; }


        #endregion

        public Navigator()
        {
            this.DefaultStyleKey = typeof(Navigator);
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or
        /// internal processes (such as a rebuilding layout pass) call
        /// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            navControl = this;
            base.OnApplyTemplate();
            ResetRotationGrid = GetTemplateChild("ResetRotationGrid") as FrameworkElement;
            SlantSlider = GetTemplateChild("SlantSlider") as Slider;
            SlantSliderGrid = GetTemplateChild("SlantSliderGrid") as FrameworkElement;
            NavCircle = GetTemplateChild("NavCircle") as Border;
            ZoomGrid = GetTemplateChild("ZoomGrid_") as FrameworkElement;
            ZoomGridOuterBorder = GetTemplateChild("ZoomGridBorder1") as Border;
            ZoomGridInnerBorder = GetTemplateChild("ZoomGridBorder2") as Border;
            SlantText = GetTemplateChild("SlantText_") as TextBlock;
            SlantGlass = GetTemplateChild("GlobeGlass") as FrameworkElement;
            ZoomGridStack = GetTemplateChild("ZoomGridStack") as StackPanel;
            BottomZoomWingUpDownExpand = GetTemplateChild("BottomZoomWingUpDownExpand") as UpDownExpand;
            TopZoomWingUpDownExpand = GetTemplateChild("TopZoomWingUpDownExpand") as UpDownExpand;
            BottomZoomCollapseButton = GetTemplateChild("BottomZoomWingCollapseButton") as Button;
            TopZoomCollapseButton = GetTemplateChild("TopZoomWingCollapseButton") as Button;
            ExpandZoomBar = GetTemplateChild("ExpandZoomBar") as Storyboard;
            ShrinkZoomBar = GetTemplateChild("ShrinkZoomBar") as Storyboard;
            ExpandProgressBarSpacer = GetTemplateChild("ExpandProgressBarSpacer") as Storyboard;
            ShrinkProgressBarSpacer = GetTemplateChild("ShrinkProgressBarSpacer") as Storyboard;
            NavProjection = GetTemplateChild("NavProjection") as PlaneProjection;

            ScaleLine = GetTemplateChild("ScaleLine") as ScaleLine;
            root = GetTemplateChild("root") as FrameworkElement;
            NavOpacitySliderGrid = GetTemplateChild("NavOpacitySliderGrid") as FrameworkElement;
            NavOpacitySlider = GetTemplateChild("NavOpacitySlider") as Slider;
            OpacityText = GetTemplateChild("OpacityText") as FrameworkElement;
            progressBarGrid = GetTemplateChild("progressBarGrid") as FrameworkElement;
            ScaleBarInnerBorder = GetTemplateChild("ScaleBarInnerBorder") as Border;
            ScaleBarWingCollapseButton = GetTemplateChild("ScaleBarWingCollapseButton") as Button;
            ScaleBarOuterBorder = GetTemplateChild("ScaleBarOuterBorder") as Border;
            progressBar = GetTemplateChild("progressBar") as MapProgressBar;
            ScaleBarWingLeftRightExpand = GetTemplateChild("ScaleBarWingLeftRightExpand") as LeftRightExpand;

            if (ExpandProgressBarSpacer != null)
                ExpandProgressBarSpacer.Completed += expandprogressbarSpacer_Completed;
            if (ExpandZoomBar != null)
                ExpandZoomBar.Completed += ExpandZoomBar_Completed;
            if (ShrinkZoomBar != null)
                ShrinkZoomBar.Completed += ShrinkZoomBar_Completed;
            if (ScaleBarWingCollapseButton != null)
                ScaleBarWingCollapseButton.Click += ScaleBarWingCollapseButton_Click;
            if (BottomZoomCollapseButton != null)
                BottomZoomCollapseButton.Click += ZoomWingCollapseButton_Click;
            if (TopZoomCollapseButton != null)
                TopZoomCollapseButton.Click += ZoomWingCollapseButton_Click;
            if (SlantGlass != null)
                SlantGlass.MouseLeftButtonDown += GlobeGlass_MouseLeftButtonDown;
            if (SlantSlider != null)
                SlantSlider.ValueChanged += SlantSlider_ValueChanged;
            if (NavOpacitySlider != null)
                NavOpacitySlider.ValueChanged += NavOpacitySlider_ValueChanged;
            ResourceDictionary rd = root.Resources;
            // try local resources first for zoom level brushes
            levelGreaterThanBrush = rd["levelGreaterThanBrush"] as SolidColorBrush;
            levelLessThanBrush = rd["levelLessThanBrush"] as SolidColorBrush;
            levelEqualsBrush = rd["levelEqualsBrush"] as SolidColorBrush;
            if (levelGreaterThanBrush == null)
            {
                // if local resources not used, try the application global resources
                rd = Application.Current.Resources;
                levelGreaterThanBrush = rd["levelGreaterThanBrush"] as SolidColorBrush;
                levelLessThanBrush = rd["levelLessThanBrush"] as SolidColorBrush;
                levelEqualsBrush = rd["levelEqualsBrush"] as SolidColorBrush;
            }

            VerticalAlignment va = this.VerticalAlignment;
            if (va == VerticalAlignment.Bottom)
            {
                bottomAligned = true;
                ScaleBarOuterBorder.CornerRadius = new CornerRadius(0, 21, 0, 0);
                ScaleBarOuterBorder.VerticalAlignment = VerticalAlignment.Bottom;
                ScaleBarInnerBorder.CornerRadius = new CornerRadius(0, 20, 0, 0);
                OpacityText.VerticalAlignment = VerticalAlignment.Bottom;
                NavOpacitySliderGrid.VerticalAlignment = VerticalAlignment.Bottom;

                ZoomGridOuterBorder.CornerRadius = new CornerRadius(0, 21, 0, 0);
                ZoomGridInnerBorder.CornerRadius = new CornerRadius(0, 20, 0, 0);
                ZoomGrid.VerticalAlignment = VerticalAlignment.Bottom;
                ZoomGridOuterBorder.VerticalAlignment = VerticalAlignment.Top;
                ZoomGridInnerBorder.Padding = new Thickness(5, 5, 5, 110);
                NavCircle.VerticalAlignment = VerticalAlignment.Bottom;
                NavCircle.RenderTransformOrigin = new Point(0, 1);
                SlantSliderGrid.Margin = new Thickness(85, 0, 0, 6);
                SlantSliderGrid.VerticalAlignment = VerticalAlignment.Bottom;
                SlantText.VerticalAlignment = VerticalAlignment.Bottom;
                ResetRotationGrid.VerticalAlignment = VerticalAlignment.Bottom;
                BottomZoomCollapseButton.Visibility = Visibility.Collapsed;
                TopZoomCollapseButton.Visibility = Visibility.Visible;
            }
            string strvalue = Application.Current.Resources["UsePlaneProjection"] as string;
            if (strvalue != null)
                usePlaneProjection = bool.Parse(strvalue);
            if (mapAngle != 0 && usePlaneProjection)
                SlantSlider.Value = mapAngle;
            if (this.Map != null)
            {
                if (ScaleLine != null)
                {
                    ScaleLine.Map = Map;
                    ScaleLine.TargetWidth = TargetWidth;
                }
                Map.Progress += projectionCheck;
                Map.Progress += progressBarCheck;
            }

        }



        #region Properties



        /// <summary>
        /// Gets or sets angle of map view. Ignored if UseMapProjection is set to False.
        /// </summary>
        public double MapAngle
        {
            get { return (double)GetValue(MapAngleProperty); }
            set { SetValue(MapAngleProperty, value); }
        }

        public static readonly DependencyProperty MapAngleProperty =
            DependencyProperty.Register("MapAngle", typeof(double), typeof(Navigator), new PropertyMetadata(0d, OnMapAnglePropertyChanged));

        private static void OnMapAnglePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Navigator n = d as Navigator;
            double angle = (double)e.NewValue;
            if (!double.IsNaN(angle))
            {
                n.mapAngle = angle;
                if (n.SlantSlider != null)
                    n.SlantSlider.Value = angle;

            }
        }

        /// <summary>
        /// Identifies the <see cref="TargetWidth"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TargetWidthProperty = DependencyProperty.Register("TargetWidth", typeof(double), typeof(Navigator), new PropertyMetadata(150.0));

        /// <summary>
        /// Gets or sets the target width of the scale line.
        /// </summary>
        /// <remarks>The actual width of the scale bar changes when values are rounded.</remarks>
        public double TargetWidth
        {
            get { return (double)GetValue(TargetWidthProperty); }
            set { SetValue(TargetWidthProperty, value); }
        }

        #endregion


        #region Setup Methods

        // sets map of progressbar
        private void progressBarCheck(object sender, ProgressEventArgs e)
        {
            if (progressBar != null)
            {
                if (progressBar.Map == null)
                {
                    progressBar.Map = navControl.Map;
                    navControl.Map.Progress -= progressBarCheck;
                }
            }
        }

        // sets up use of plane projection
        private void projectionCheck(object sender, ProgressEventArgs e)
        {
            if (SlantSliderGrid != null)
            {
                if (usePlaneProjection)
                {
                    if (MapProjection != null)
                    {
                        SlantSliderGrid.Visibility = Visibility.Visible;
                        SlantGlass.Visibility = Visibility.Visible;
                        SlantText.Visibility = Visibility.Visible;
                        SlantSlider.Value = mapAngle;
                    }
                    else
                    {
                        SlantSliderGrid.Visibility = Visibility.Collapsed;
                        SlantGlass.Visibility = Visibility.Collapsed;
                        SlantText.Visibility = Visibility.Collapsed;
                    }
                }
                else
                {
                    SlantSliderGrid.Visibility = Visibility.Collapsed;
                    SlantGlass.Visibility = Visibility.Collapsed;
                    SlantText.Visibility = Visibility.Collapsed;
                    usePlaneProjection = false;
                }
                Map.Progress -= projectionCheck;
            }

        }

        #endregion


        #region Events
        // Event handler for opacity slider
        private void NavOpacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (root != null)
                root.Opacity = e.NewValue;
        }

        #endregion


        #region Map Slant

        private void SlantSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Map != null)
            {
                double angle = e.NewValue;
                NavProjection.RotationX = angle;
                MapProjection.RotationX = angle;
                //if (OverviewMap2 != null) OverviewMap2.MapAngle = angle;
            }
        }

        private void GlobeGlass_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
            lastY = startPoint.Y;
            SlantGlass.MouseMove += SlantGlass_MouseMove;
            SlantGlass.MouseLeftButtonUp += SlantGlass_MouseLeftButtonUp;
            SlantGlass.MouseLeave += SlantGlass_MouseLeave;
        }

        void SlantGlass_MouseLeave(object sender, MouseEventArgs e)
        {
            SlantGlass.MouseMove -= SlantGlass_MouseMove;
            SlantGlass.MouseLeftButtonUp -= SlantGlass_MouseLeftButtonUp;
            SlantGlass.MouseLeave -= SlantGlass_MouseLeave;
        }

        void SlantGlass_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SlantGlass.MouseMove -= SlantGlass_MouseMove;
            SlantGlass.MouseLeftButtonUp -= SlantGlass_MouseLeftButtonUp;

        }

        void SlantGlass_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(null);
            double diff = pt.Y - lastY;
            double slant = SlantSlider.Value;
            double newSlant = slant += diff;
            if (newSlant <= SlantSlider.Maximum && newSlant >= SlantSlider.Minimum) SlantSlider.Value = newSlant;
        }
        #endregion


        #region Wing methods
        private void ZoomWingCollapseButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanel zes = ZoomGridStack;
            Visibility vis = zes.Visibility;
            BottomZoomWingUpDownExpand.Visibility = Visibility.Collapsed;
            TopZoomWingUpDownExpand.Visibility = Visibility.Collapsed;
            if (vis == Visibility.Collapsed)
            {
                ExpandZoomBar.Begin();
                TopZoomWingUpDownExpand.IsPointingDown = true;
                BottomZoomWingUpDownExpand.IsPointingDown = false;

            }
            else
            {
                NavOpacitySliderGrid.Visibility = Visibility.Collapsed;
                OpacityText.Visibility = Visibility.Collapsed;
                zes.Visibility = Visibility.Collapsed;
                ZoomGridInnerBorder.Padding = bottomAligned ? new Thickness(5, 0, 5, 70) : new Thickness(5, 70, 5, 0);
                TopZoomWingUpDownExpand.IsPointingDown = false;
                BottomZoomWingUpDownExpand.IsPointingDown = true;
                ShrinkZoomBar.Begin();
            }
        }

        private void ScaleBarWingCollapseButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility vis = ScaleLine.Visibility;

            if (vis == Visibility.Collapsed)
            {
                ExpandProgressBarSpacer.Begin();
                ScaleBarWingLeftRightExpand.IsPointingRight = false;
            }
            else
            {
                ScaleLine.Visibility = Visibility.Collapsed;
                progressBarGrid.Visibility = Visibility.Collapsed;
                SlantSliderGrid.Visibility = Visibility.Collapsed;
                SlantText.Visibility = Visibility.Collapsed;
                ScaleBarWingLeftRightExpand.IsPointingRight = true;

                ShrinkProgressBarSpacer.Begin();
                ScaleBarInnerBorder.Padding = new Thickness(70, 2, 0, 2);
            }
        }

        private void expandprogressbarSpacer_Completed(object sender, EventArgs e)
        {
            ScaleLine.Visibility = Visibility.Visible;
            progressBarGrid.Visibility = Visibility.Visible;
            if (usePlaneProjection)
            {
                SlantSliderGrid.Visibility = Visibility.Visible;
                SlantText.Visibility = Visibility.Visible;
            }
            ScaleBarInnerBorder.Padding = new Thickness(100, 2, 0, 2);
        }

        private void ExpandZoomBar_Completed(object sender, EventArgs e)
        {
            ZoomGridStack.Visibility = Visibility.Visible;
            NavOpacitySliderGrid.Visibility = Visibility.Visible;
            OpacityText.Visibility = Visibility.Visible;
            ZoomGridInnerBorder.Padding = bottomAligned ? new Thickness(5, 0, 5, 110) : new Thickness(5, 110, 5, 0);
            if (bottomAligned)
                TopZoomWingUpDownExpand.Visibility = Visibility.Visible;
            else
                BottomZoomWingUpDownExpand.Visibility = Visibility.Visible;

        }

        private void ShrinkZoomBar_Completed(object sender, EventArgs e)
        {
            if (bottomAligned)
                TopZoomWingUpDownExpand.Visibility = Visibility.Visible;
            else
                BottomZoomWingUpDownExpand.Visibility = Visibility.Visible;

        }

        #endregion

    }
}
