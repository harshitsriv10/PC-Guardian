﻿#pragma checksum "..\..\createUser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A89F793A83991CF89DF5DFE6C700185"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PCGaurdianV1;
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


namespace PCGaurdianV1 {
    
    
    /// <summary>
    /// createUser
    /// </summary>
    public partial class createUser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label unameName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox unametxt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nomatch;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock exist;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkuname;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blkpass;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passtxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cpass;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox cpasstxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newUser;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\createUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/PCGaurdianV1;component/createuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\createUser.xaml"
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
            this.unameName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.unametxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\createUser.xaml"
            this.unametxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.unametxt_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nomatch = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.exist = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.blkuname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.blkpass = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.pass = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.passtxt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.cpass = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.cpasstxt = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 29 "..\..\createUser.xaml"
            this.cpasstxt.PasswordChanged += new System.Windows.RoutedEventHandler(this.cpasstxt_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.newUser = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\createUser.xaml"
            this.newUser.Click += new System.Windows.RoutedEventHandler(this.newUser_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\createUser.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

