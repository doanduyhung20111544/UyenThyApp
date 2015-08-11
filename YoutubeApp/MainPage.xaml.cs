using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using YoutubeApp.Resources;
using GoogleAds;
using YoutubeApp.Model;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;
using Microsoft.Advertising.Mobile.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace YoutubeApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            //ad_banner.Format = AdFormats.Banner;
            //ad_banner.AdUnitID = "ca-app-pub-9878130893369780/3779606154";
            //AdRequest adRequest = new AdRequest();
            //adRequest.ForceTesting = true;
            //ad_banner.LoadAd(adRequest);
            //ad_banner.ReceivedAd += OnAdReceived;
            //ad_banner.FailedToReceiveAd += OnFailedToReceiveAd;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            //AdUnit.ErrorOccurred += AdUnit_ErrorOccurred;

            //Grid grd = (Grid)AdUnit.Parent;
            
            //AdView bannerAd = new AdView
            //{
            //    Format = AdFormats.Banner,
            //    AdUnitID = "233067"
            //};
            //AdRequest adRequest = new AdRequest();
            //bannerAd.LoadAd(adRequest);
            
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.
            
            double width = Application.Current.RootVisual.RenderSize.Width - 20;
            YoutubeMethod ytb = new YoutubeMethod();
            
            
            await ytb.channelInfo();
            playlist_listbox.ItemsSource = await ytb.playlist_Channel();
            avatar_image.Source = new BitmapImage(new Uri(ytb.Channel_Avatar, UriKind.RelativeOrAbsolute));

            //turn_on_Page();
            //await ytb.playlist_Channel();

            //playlist_listbox.ItemsSource = ytb.playlist_Channel;
            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void playlist_listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlaylistInfo myobject = (sender as LongListSelector).SelectedItem as PlaylistInfo;
            if (myobject != null)
            {
                //this.Frame.Navigate(typeof(PlaylistChannelPage), myobject.Id);
                NavigationService.Navigate(new Uri("/View/PlaylistChannelPage.xaml?msg=" + myobject.Id, UriKind.Relative));
            }
        }

        private void videochannel_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(VideoChannelPage));
            
        }

        private void StackPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/VideoChannelPage.xaml", UriKind.Relative));
        }

        //private void AdControl_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine("Ad Error : ({0}) {1}", e.ErrorCode, e.Error);
        //}

        private void AdUnit_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ad Error : ({0}) {1}", e.ErrorCode, e.Error);
        }

        private void AdUnit_AdSdkError(object sender, Microsoft.AdMediator.Core.Events.AdFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ad Error : ({0}) {1}", e.ErrorCode, e.Error);
        }

        private void AdUnit_AdMediatorError(object sender, Microsoft.AdMediator.Core.Events.AdMediatorFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ad Error : ({0}) {1}", e.ErrorCode, e.Error);
        }

        //private void AdUnit_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    {
        //        AdControl ad = (AdControl)sender;
        //        Grid grd = (Grid)ad.Parent;
        //        System.Windows.Deployment.Current.Dispatcher.BeginInvoke(() =>
        //        {
        //            AdView bannerAd = new AdView
        //            {
        //                Format = AdFormats.Banner,
        //                AdUnitID = "233067"
        //            };
        //            AdRequest adRequest = new AdRequest();
        //            grd.Children.Add(bannerAd);
        //            bannerAd.LoadAd(adRequest);
        //        });
        //        System.Diagnostics.Debug.WriteLine(e.Error.Message);
        //    }
        //}



    }
}