using App4.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;


            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        

        private void Sleep_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sleep));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bath_Tapped(object sender, TappedRoutedEventArgs e)
        {
this.Frame.Navigate(typeof(tolet));
        }

        private void dress_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(dress));
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(about));
        }

        private void food_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(foodxaml));
        }

        private void asd_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(asd));
        }

        private void Spalli_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(palli));
        }

        private void veedu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(veedu));
        }

        private void travel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(travel));
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(situation));
        }

        private void s_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(s));
        }

        private void v_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(v));
        }

        private void m_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(situation));
        }

        private void pray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(prayer));
        }

        private void mng_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mng));
        }

        private void quran_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(quran));
        }

       }
    }

