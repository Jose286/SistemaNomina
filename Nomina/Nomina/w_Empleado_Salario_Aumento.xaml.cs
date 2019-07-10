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

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (dgAumentoSalarial.SelectedItem != null)
            {

                Empleado_Salario_Historico h = new Empleado_Salario_Historico();

                Empleado em = new Empleado();



                //Se carga los datos historicos, el empleado, el salario anterior y el nuevo con la fecha
                //h.Empleado_Id = em.Id_Empleado;
                // h.Salario_Basico_Anterior = em.Salario_Basico;
                // h.Salario_Basico_Anterior = int.Parse(txtNuevoSalario.Text);
                // h.Fecha_Hora = DateTime.Today;

                //Se actualiza el salario nuevo del empleado despues de haber guardado el dato historico                
                // em.Salario_Basico = int.Parse(txtNuevoSalario.Text);

                datos.Empleado_Salario_Historico.Add(h);
                datos.SaveChanges();

            }
        }
    }
}
