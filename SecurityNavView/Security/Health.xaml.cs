﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Security
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Health : Page
    {
        bool checking = false;
        public Health()
        {
            this.InitializeComponent();
        }

        private async void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (checking == false)
            {
                txtBlockD.Text = "Checking your PC...";
                CheckButton.Visibility = Visibility.Collapsed;
                progresB.Visibility = Visibility.Visible;
                checking = true;
                await Task.Delay(TimeSpan.FromSeconds(5));
                checking = false;
                txtBlockD.Text = "Seems all good";
                progresB.Visibility = Visibility.Collapsed;
                CheckButton.Visibility = Visibility.Visible;


            }
        }

    }
}
