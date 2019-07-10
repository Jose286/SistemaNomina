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
    /// Lógica de interacción para w_Liquidacion_Mensual.xaml
    /// </summary>
    public partial class w_Liquidacion_Mensual : Window
    {
        NominaEntities datos;
        public w_Liquidacion_Mensual()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime Hoy = DateTime.Now;
            txtMes.Text = Hoy.ToString("MM");
            txtAño.Text = Hoy.ToString("yyyy");
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Liquidacion_Mensual Mensual = new Liquidacion_Mensual();

            Mensual.Mes = short.Parse(txtMes.Text);
            Mensual.Anho = short.Parse(txtAño.Text);
            Mensual.Estado = "A";
            Mensual.Fecha_Generacion = DateTime.Now;
            
            Mensual.Usuario_Id = ProyectoNomina.Properties.Settings.Default.usuarioLogeado;

            datos.Liquidacion_Mensual.Add(Mensual);
            datos.SaveChanges();
            MessageBox.Show("Liquidación Creada correctamente!  " + txtMes.Text + "-" + txtAño.Text);

        }

       
    }
}
