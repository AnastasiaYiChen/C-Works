﻿#pragma checksum "C:\Users\Yi Chen\source\repos\UWP-App1\UWP-App1\FileSystem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2AA1492DD6636157C60680FF4E8A643F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_App1
{
    partial class FileSystem : 
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
            case 2: // FileSystem.xaml line 13
                {
                    this.CreateAFile_BTN = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CreateAFile_BTN).Click += this.CreateAFile_BTN_Click;
                }
                break;
            case 3: // FileSystem.xaml line 21
                {
                    this.userInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // FileSystem.xaml line 22
                {
                    this.FilePath_TxtBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // FileSystem.xaml line 24
                {
                    this.ReadFile_BTN = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ReadFile_BTN).Click += this.ReadFile_BTN_Click;
                }
                break;
            case 6: // FileSystem.xaml line 32
                {
                    this.readBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // FileSystem.xaml line 34
                {
                    this.label = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

