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
    /// Lógica de interacción para w_Empleado_Salario_Aumento.xaml
    /// </summary>
    public partial class w_Empleado_Salario_Aumento : Window
    {

        NominaEntities datos;
        public w_Empleado_Salario_Aumento()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }


        private void CargarDatosGrilla()
        {
            try
            {
                dgAumentoSalarial.ItemsSource = datos.Empleado.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DgAumentoSalarial_Loaded(object sender, RoutedEventArgs e)
        {
            CargarDatosGrilla();
        }
    }
}
