﻿#pragma checksum "..\..\TurnRatingsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB9EF44FCB8EA3A3251F08EF6D2C2BCB5B6C5412764A47FE424B701E4C7DA05B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clinic;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Clinic {
    
    
    /// <summary>
    /// TurnRatingsWindow
    /// </summary>
    public partial class TurnRatingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Searchbtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DoctorSpecialtyTxt;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Drname;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NamePtxt;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FmailyPtxt;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GenderPtxt;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel DRforPatinSact;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\TurnRatingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Regster;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Clinic;component/turnratingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TurnRatingsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Searchbtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\TurnRatingsWindow.xaml"
            this.Searchbtn.Click += new System.Windows.RoutedEventHandler(this.Searchbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DoctorSpecialtyTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Drname = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.NamePtxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.FmailyPtxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.GenderPtxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.DRforPatinSact = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.Regster = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\TurnRatingsWindow.xaml"
            this.Regster.Click += new System.Windows.RoutedEventHandler(this.Regster_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

