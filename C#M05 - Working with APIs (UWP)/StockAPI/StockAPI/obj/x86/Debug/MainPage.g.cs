﻿#pragma checksum "C:\Users\Yi Chen\source\repos\StockAPI\StockAPI\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7534A5B93F061D3346452812E518ECD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockAPI
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 30
                {
                    this.Click_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Click_Btn).Click += this.Click_Btn_Click;
                }
                break;
            case 3: // MainPage.xaml line 32
                {
                    this.dataGrid = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                }
                break;
            case 4: // MainPage.xaml line 37
                {
                    this.dataGrid1 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                }
                break;
            case 5: // MainPage.xaml line 40
                {
                    this.Lab_01 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 41
                {
                    this.Lab_02 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

