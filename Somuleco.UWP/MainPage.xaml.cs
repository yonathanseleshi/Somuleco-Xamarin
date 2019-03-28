using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Somuleco.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        public void Unauthenticated_click(Object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Unauthenticated));
        }

        public void Authenticated_click(Object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Authenticated));
        }

        public void Authentication_click(Object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Authentication));
        }

     
    }
}
