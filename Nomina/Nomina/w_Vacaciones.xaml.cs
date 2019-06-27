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
    /// Lógica de interacción para w_vacaciones.xaml
    /// </summary>
    public partial class w_Vacaciones : Window
    {

        NominaEntities datos;
        public w_Vacaciones()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }
        private void Visualizar()
        {
            try
            {
                dgVacaciones.ItemsSource = datos.Vacaciones.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void dgVacaciones_Loaded(object sender, RoutedEventArgs e)
        {
            Visualizar();
        }

        private void BtnAprobar_Click(object sender, RoutedEventArgs e)
        {
            if (dgVacaciones.SelectedItem != null)
            {
                Vacaciones v = (Vacaciones)dgVacaciones.SelectedItem;
                if (v.Estado == "Pendiente")
                {
                    v.Estado = "Aprobado";
                    MessageBox.Show("Se Aprobo las vacaciones");
                }
                else
                    MessageBox.Show("Las vacaciones ya estan procesadas");
                datos.SaveChanges();
                Visualizar();
            }
            else
                MessageBox.Show("Debe solicionar unas vacaciones para poder  procesarlo!");
        }

        private void BtnRechazar_Click(object sender, RoutedEventArgs e)
        {

            if (dgVacaciones.SelectedItem != null)
            {
                Vacaciones v = (Vacaciones)dgVacaciones.SelectedItem;
                if (v.Estado == "Pendiente")
                {
                    v.Estado = "Rechazado";
                    MessageBox.Show("Se Rechazo las vacaciones");
                }
                else
                    MessageBox.Show("Las vacaciones ya estan procesadas");
                datos.SaveChanges();
                Visualizar();
            }
            else
                MessageBox.Show("Debe solicionar unas vacaciones para poder  procesarlo!");
        }
    }
}
