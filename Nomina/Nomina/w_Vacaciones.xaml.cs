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
    }
}
