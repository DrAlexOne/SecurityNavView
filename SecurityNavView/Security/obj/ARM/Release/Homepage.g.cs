﻿#pragma checksum "D:\Alex\Visual\SecurityNavView\Security\Homepage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C2868B4F84B8135A08AEEFB1EDE3CC42"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Security
{
    partial class Homepage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Homepage.xaml line 12
                {
                    this.RectangleAcrylic = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 3: // Homepage.xaml line 17
                {
                    this.txtBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Homepage.xaml line 18
                {
                    this.pb = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 5: // Homepage.xaml line 45
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.NextInfo;
                }
                break;
            case 6: // Homepage.xaml line 48
                {
                    this.txt2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Homepage.xaml line 46
                {
                    this.HomeIcon = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 8: // Homepage.xaml line 41
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.AppBarButton_Click;
                }
                break;
            case 9: // Homepage.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.AppBarButton_Click_2;
                }
                break;
            case 10: // Homepage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.AppBarButton_Click_3;
                }
                break;
            case 11: // Homepage.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.ItemsControl element11 = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ItemsControl)element11).PointerPressed += this.ToDefender;
                }
                break;
            case 12: // Homepage.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.ItemsControl element12 = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ItemsControl)element12).PointerPressed += this.ComingSoon;
                }
                break;
            case 13: // Homepage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.ItemsControl element13 = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ItemsControl)element13).PointerPressed += this.BatteryInfo;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
