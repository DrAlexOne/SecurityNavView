﻿#pragma checksum "D:\Alex\Visual\SecurityNavView\Security\BatteryInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9995FE2995E04D49F3B931B016A12248"
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
    partial class BatteryInfo : 
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
            case 2: // BatteryInfo.xaml line 35
                {
                    this.BatteryReportPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // BatteryInfo.xaml line 29
                {
                    this.GetBatteryReportButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.GetBatteryReportButton).Click += this.GetBatteryReport;
                }
                break;
            case 4: // BatteryInfo.xaml line 25
                {
                    this.AggregateButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 5: // BatteryInfo.xaml line 26
                {
                    this.IndividualButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6: // BatteryInfo.xaml line 13
                {
                    this.RectangleAcrylic = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7: // BatteryInfo.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.ToHome1;
                }
                break;
            case 8: // BatteryInfo.xaml line 20
                {
                    this.HomeIcon = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
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
