﻿#pragma checksum "C:\Users\doanduyhung\documents\visual studio 2013\Projects\YoutubeApp\YoutubeApp\View\VideoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B3686EF2CF3B9610557C20074F57D0F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace YoutubeApp.View {
    
    
    public partial class VideoPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.Animation.Storyboard slider_sb;
        
        internal System.Windows.Media.Animation.Storyboard image_sb;
        
        internal System.Windows.Controls.MediaElement video_element;
        
        internal System.Windows.Controls.Image center_image;
        
        internal System.Windows.Controls.Slider timelineSlider;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/YoutubeApp;component/View/VideoPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.slider_sb = ((System.Windows.Media.Animation.Storyboard)(this.FindName("slider_sb")));
            this.image_sb = ((System.Windows.Media.Animation.Storyboard)(this.FindName("image_sb")));
            this.video_element = ((System.Windows.Controls.MediaElement)(this.FindName("video_element")));
            this.center_image = ((System.Windows.Controls.Image)(this.FindName("center_image")));
            this.timelineSlider = ((System.Windows.Controls.Slider)(this.FindName("timelineSlider")));
        }
    }
}

