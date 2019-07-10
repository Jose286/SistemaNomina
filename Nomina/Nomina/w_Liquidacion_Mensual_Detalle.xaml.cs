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
        //private const string V = "Mes";
        NominaEntities datos;
        public w_Liquidacion_Mensual_Detalle()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboLiquidacion.ItemsSource = datos.Liquidacion_Mensual.ToList();
            cboLiquidacion.DisplayMemberPath = "Mes";
            cboLiquidacion.SelectedValuePath = "Id_Liquidacion";

            cboEmpleado.ItemsSource = datos.Empleado.ToList();
            cboEmpleado.DisplayMemberPath = "Nombres";
            cboEmpleado.SelectedValuePath = "Id_Empleado";

            cboConcepto.ItemsSource = datos.Concepto.ToList();
            cboConcepto.DisplayMemberPath = "Descripcion";
            cboConcepto.SelectedValuePath = "Id_Concepto";

        }

        private void DgConceptosLiquidacion_Loaded(object sender, RoutedEventArgs e)
        {
            CargarGrillaConceptoLiquidacion();
        }


        public void CargarGrillaConceptoLiquidacion()
        {
            dgConceptosLiquidacion.ItemsSource = datos.Liquidacion_Mensual_Detalle.ToList();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtMonto.Text == "")
            {
                MessageBox.Show("Cargar Monto");
                txtMonto.Focus();
            }

            Liquidacion_Mensual_Detalle liquimen = new Liquidacion_Mensual_Detalle();
            liquimen.Liquidacion_Mensual = (Liquidacion_Mensual)cboLiquidacion.SelectedItem;
            liquimen.Empleado = (Empleado)cboEmpleado.SelectedItem;
            liquimen.Concepto = (Concepto)cboConcepto.SelectedItem;
            liquimen.Monto = Convert.ToInt32(txtMonto.Text);

            if (liquimen.Liquidacion_Mensual != null && liquimen.Empleado != null && liquimen.Concepto != null && liquimen.Monto !=0)
            {
                datos.Liquidacion_Mensual_Detalle.Add(liquimen);
                datos.SaveChanges();
                CargarGrillaConceptoLiquidacion();
            }

            else MessageBox.Show("fatltan datos");
        }
    }
}