﻿#pragma checksum "..\..\w_Empleado_Salario_Aumento.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "511090B0E38036907DE9D532DE5F76862407965C3B31047C7DA2FFAE95FC2D3B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Nomina;
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


namespace Nomina {
    
    
    /// <summary>
    /// w_Empleado_Salario_Aumento
    /// </summary>
    public partial class w_Empleado_Salario_Aumento : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\w_Empleado_Salario_Aumento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAumentoSalarial;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\w_Empleado_Salario_Aumento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\w_Empleado_Salario_Aumento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNuevoSalario;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\w_Empleado_Salario_Aumento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
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
            System.Uri resourceLocater = new System.Uri("/Nomina;component/w_empleado_salario_aumento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\w_Empleado_Salario_Aumento.xaml"
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
            this.dgAumentoSalarial = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\w_Empleado_Salario_Aumento.xaml"
            this.dgAumentoSalarial.Loaded += new System.Windows.RoutedEventHandler(this.DgAumentoSalarial_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtNuevoSalario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\w_Empleado_Salario_Aumento.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.BtnActualizar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

