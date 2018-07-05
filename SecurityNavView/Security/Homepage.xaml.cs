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
using Windows.Devices.Power;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Core;
using Windows.UI;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Security
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Homepage : Page
    {
        string color = "light";
        int InfoPage = 1;
        public Homepage()
        {
            this.InitializeComponent();

            var aggBattery = Battery.AggregateBattery;
            var report = aggBattery.GetReport();

            txtBlock.Text = report.Status.ToString();


            //xtBlock.Text = report.ChargeRateInMilliwatts.ToString();

            txtBlock.Text = report.Status.ToString();
            txt2.Visibility = Visibility.Collapsed;

            if ((report.FullChargeCapacityInMilliwattHours == null) ||
                (report.RemainingCapacityInMilliwattHours == null))
            {
                pb.IsEnabled = false;
                txtBlock.Text = "N/A";
            }
            else
            {
                pb.IsEnabled = true;
                pb.Maximum = Convert.ToDouble(report.FullChargeCapacityInMilliwattHours);
                pb.Value = Convert.ToDouble(report.RemainingCapacityInMilliwattHours);
                //txtBlock.Text = ((pb.Value / pb.Maximum) * 100).ToString("F2") + "%";
            }
        }

        void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            //Random rnd = new Random();
            var aggBattery = Battery.AggregateBattery;
            var report = aggBattery.GetReport();


            //xtBlock.Text = report.ChargeRateInMilliwatts.ToString();

            txtBlock.Text = report.Status.ToString();
            txt2.Visibility = Visibility.Collapsed;

            if ((report.FullChargeCapacityInMilliwattHours == null) ||
                (report.RemainingCapacityInMilliwattHours == null))
            {
                pb.IsEnabled = false;
                txtBlock.Text = "N/A";
            }
            else
            {
                pb.IsEnabled = true;
                pb.Maximum = Convert.ToDouble(report.FullChargeCapacityInMilliwattHours);
                pb.Value = Convert.ToDouble(report.RemainingCapacityInMilliwattHours);
                //txtBlock.Text = ((pb.Value / pb.Maximum) * 100).ToString("F2") + "%";
            }
        }

        private async void ComingSoon(object sender, PointerRoutedEventArgs e)
        {
            ContentDialog ComingSoon = new ContentDialog
            {
                Title = "Coming soon",
                Content = "Please, wait for next updates",
                CloseButtonText = "OK"
            };

            ContentDialogResult result = await ComingSoon.ShowAsync();
        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Settings));
        }

        private void ToDefender(object sender, PointerRoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void BatteryInfo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BatteryInfo), color);

        }

        private void NextInfo(object sender, RoutedEventArgs e)
        {
            InfoPage = InfoPage + 1;
            if (InfoPage == 3)
            {
                InfoPage = 1;
            }
            if (InfoPage == 1)
            {
                var aggBattery = Battery.AggregateBattery;
                var report = aggBattery.GetReport();


                //xtBlock.Text = report.ChargeRateInMilliwatts.ToString();

                txtBlock.Text = report.Status.ToString();
                txt2.Visibility = Visibility.Collapsed;
                pb.Visibility = Visibility.Visible;

                if ((report.FullChargeCapacityInMilliwattHours == null) ||
                    (report.RemainingCapacityInMilliwattHours == null))
                {
                    pb.IsEnabled = false;
                    txtBlock.Text = "N/A";
                }
                else
                {
                    pb.IsEnabled = true;
                    pb.Maximum = Convert.ToDouble(report.FullChargeCapacityInMilliwattHours);
                    pb.Value = Convert.ToDouble(report.RemainingCapacityInMilliwattHours);
                    //txtBlock.Text = ((pb.Value / pb.Maximum) * 100).ToString("F2") + "%";
                }
            }
            if (InfoPage == 2)
            {
                pb.Visibility = Visibility.Collapsed;
                txtBlock.Text = "Seems all good";
                txt2.Text = "Viruses dont found";
                txt2.Visibility = Visibility.Visible;
            }
        }
    }
}
