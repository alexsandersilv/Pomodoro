﻿#pragma checksum "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085685F44B427BE159DC85280E20032209DC4D56"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pomodoro.Views.Controllers;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Pomodoro.Views.Controllers {
    
    
    /// <summary>
    /// TimerButtonsControl
    /// </summary>
    public partial class TimerButtonsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayAndPause;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IconsPlayPause;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stop;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Remove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pomodoro;component/views/controllers/timerbuttonscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PlayAndPause = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
            this.PlayAndPause.Click += new System.Windows.RoutedEventHandler(this.PlayAndPause_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IconsPlayPause = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Stop = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
            this.Stop.Click += new System.Windows.RoutedEventHandler(this.Stop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Remove = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\Views\Controllers\TimerButtonsControl.xaml"
            this.Remove.Click += new System.Windows.RoutedEventHandler(this.Remove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

