﻿#pragma checksum "..\..\..\Forms\AddClients.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA782B165767BE358E571E8176343C65FBC057A37438E585CC1A9261B124A475"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CursachDBapp.Forms;
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


namespace CursachDBapp.Forms {
    
    
    /// <summary>
    /// AddClients
    /// </summary>
    public partial class AddClients : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 201 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewClients;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ClientID;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ClientName;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ClientStatus;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ClientPhone;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button3;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox2;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox3;
        
        #line default
        #line hidden
        
        
        #line 246 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox4;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\Forms\AddClients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker TimePicker1;
        
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
            System.Uri resourceLocater = new System.Uri("/CursachDBapp;component/forms/addclients.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\AddClients.xaml"
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
            this.ListViewClients = ((System.Windows.Controls.ListView)(target));
            
            #line 201 "..\..\..\Forms\AddClients.xaml"
            this.ListViewClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewClients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ClientID = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 3:
            this.ClientName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.ClientStatus = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.ClientPhone = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 211 "..\..\..\Forms\AddClients.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.Button1_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button3 = ((System.Windows.Controls.Button)(target));
            
            #line 218 "..\..\..\Forms\AddClients.xaml"
            this.button3.Click += new System.Windows.RoutedEventHandler(this.Button3_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.textBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.textBox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.textBox4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.TimePicker1 = ((System.Windows.Controls.DatePicker)(target));
            
            #line 253 "..\..\..\Forms\AddClients.xaml"
            this.TimePicker1.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.PresetTime);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

