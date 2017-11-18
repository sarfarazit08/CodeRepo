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
using System.Windows;
using System.Windows.Interactivity;
using ESRI.ArcGIS.Client;

namespace ESRI.ArcGIS.SilverlightMapApp.Actions
{
    public class SetLayerUrlAction : TargetedTriggerAction<Map>
    {
        /// <summary>
        /// Invokes the action.
        /// </summary>
        /// <param name="parameter">The parameter to the action. If the Action does not require a parameter, the parameter may be set to a null reference.</param>
        protected override void Invoke(object parameter)
        {
            if (!string.IsNullOrEmpty(LayerID))
            {
                Layer l = Target.Layers[LayerID];
                if (l is ArcGISTiledMapServiceLayer)
                {
                    (l as ArcGISTiledMapServiceLayer).Url = Url;
                }
                else if (l is ArcGISDynamicMapServiceLayer)
                {
                    (l as ArcGISDynamicMapServiceLayer).Url = Url;
                }
                else if (l is ArcGISImageServiceLayer)
                {
                    (l as ArcGISImageServiceLayer).Url = Url;
                }
            }
        }

        /// <summary>
        /// Gets or sets the ID of layer to zoom to.
        /// </summary>
        /// <value>The layer ID.</value>
        public string LayerID
        {
            get { return (string)GetValue(LayerIDProperty); }
            set { SetValue(LayerIDProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="LayerID"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty LayerIDProperty =
            DependencyProperty.Register("LayerID", typeof(string), typeof(SetLayerUrlAction), null);

        /// <summary>
        /// Gets or sets the ID of layer to zoom to.
        /// </summary>
        /// <value>The layer ID.</value>
        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="Url"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty UrlProperty =
            DependencyProperty.Register("Url", typeof(string), typeof(SetLayerUrlAction), null);

    }
}
