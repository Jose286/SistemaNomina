using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nomina
{
    /// <summary>
    /// Lógica de interacción para w_Liquidacion_Mensual_Detalle.xaml
    /// </summary>
    public partial class w_Liquidacion_Mensual_Detalle : Window
    {
        NominaEntities datos;
        public w_Liquidacion_Mensual_Detalle()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }

     


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            foreach (Liquidacion_Mensual Liquidacion in datos.Liquidacion_Mensual)
            {
                if(Liquidacion.Estado == "A")
                {
                    cboLiquidacion.ItemsSource = datos.Liquidacion_Mensual.ToList();
                    cboLiquidacion.DisplayMemberPath = "MesAño";
                    cboLiquidacion.SelectedValuePath = "Id_Liquidacion";
                }
              


            }
            cboEmpleado.ItemsSource = datos.Empleado.ToList();
            cboEmpleado.DisplayMemberPath = "NombreCompleto";
            cboEmpleado.SelectedValuePath = "Id_Empleado";

            cboConcepto.ItemsSource = datos.Concepto.ToList();
            cboConcepto.DisplayMemberPath = "Descripcion";
            cboConcepto.SelectedValuePath = "Id_Concepto";

        }

        private void DgConceptosLiquidacion_Loaded(object sender, RoutedEventArgs e)
        {
            dgConceptosLiquidacion.ItemsSource = datos.Liquidacion_Mensual_Detalle.ToList();
        }
    }
}
