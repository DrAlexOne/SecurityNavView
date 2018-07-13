using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Security
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            Windows.UI.ViewManagement.ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

            ContentFrame.Navigate(typeof(Homepage));
        }

        private void NavHome(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Homepage));
        }

        private void NavProtect(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Protect));
        }

        private void NavHealth(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Health));
        }

        private void NavBattery(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(BatteryInfo));
        }

        private void NavSettings(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Settings));
        }
    }
}
