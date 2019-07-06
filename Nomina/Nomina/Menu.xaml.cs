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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void MenuEmpleados_Click(object sender, RoutedEventArgs e)
        {
            w_Empleados ventanaEmpleado = new w_Empleados();
            ventanaEmpleado.ShowDialog();
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuTurnos_Click(object sender, RoutedEventArgs e)
        {
           w_Turno ventanaTurno = new w_Turno();
            ventanaTurno.ShowDialog();
        }
        private void MenuPermisos_Click(object sender, RoutedEventArgs e)
        {
            w_Permisos ventanaPermiso = new w_Permisos();
            ventanaPermiso.ShowDialog();
        }

        private void MenuAnticipos_Click(object sender, RoutedEventArgs e)
        {
            w_Anticipos ventanaAnticipos = new w_Anticipos();
            ventanaAnticipos.ShowDialog();
        }

        private void MenuConceptos_Click(object sender, RoutedEventArgs e)
        {
            w_Conceptos ventanaConceptos = new w_Conceptos();
            ventanaConceptos.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            w_Vacaciones ventanaVacaciones = new w_Vacaciones();
            ventanaVacaciones.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            w_Empleado_Salario_Aumento ventanaAumentoSalarial = new w_Empleado_Salario_Aumento();
            ventanaAumentoSalarial.ShowDialog();

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            w_Liquidacion_Mensual ventanaLiquidacion = new w_Liquidacion_Mensual();
            ventanaLiquidacion.ShowDialog();
        }
    }
}
