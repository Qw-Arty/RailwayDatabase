#pragma checksum "..\..\..\Windows\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ADB873F456BA0F60DB187D750766B46006AA426C529E6FC2F1FFAA75C72FF92D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using railwayDatabase;


namespace railwayDatabase {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TrainButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlaceButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RoalwagCarriageButton;
        
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
            System.Uri resourceLocater = new System.Uri("/railwayDatabase;component/windows/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AdminWindow.xaml"
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
            this.TrainButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Windows\AdminWindow.xaml"
            this.TrainButton.Click += new System.Windows.RoutedEventHandler(this.TrainButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PlaceButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Windows\AdminWindow.xaml"
            this.PlaceButton.Click += new System.Windows.RoutedEventHandler(this.PlaceButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Windows\AdminWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RoalwagCarriageButton = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Windows\AdminWindow.xaml"
            this.RoalwagCarriageButton.Click += new System.Windows.RoutedEventHandler(this.RoalwagCarriageButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

