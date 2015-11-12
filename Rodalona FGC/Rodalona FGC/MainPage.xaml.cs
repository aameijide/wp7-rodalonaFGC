using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Rodalona_FGC
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        void OnS1ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S1.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnS2ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S2.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnS33ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S33.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnS4ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S4.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnS5ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S5.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnS55ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S55.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnS8ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/S8.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnR5ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/R5.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnR6ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/R6.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }
    }
}