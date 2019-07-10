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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class w_Login : Window
    {
        NominaEntities datos;
        public w_Login()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
           foreach (Usuario user in datos.Usuario)
           {
                if (user.Usuario1 == txtUsuario.Text && user.Password == txtContraseña.Text)
                {


                    Menu Menu = new Menu();
                    Menu.Owner = this;
                    Menu.Show();
                    this.Hide();
                    
                    ProyectoNomina.Properties.Settings.Default.usuarioLogeado = user.Id_Usuario;

                    
                    
                }
                var UsuarioLogeado = from Logeado in datos.Usuario where Logeado.Usuario1 == txtUsuario.Text select Logeado.Id_Usuario;

                if (user.Usuario1 != txtUsuario.Text && user.Password != txtContraseña.Text)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos!" + UsuarioLogeado );
                }

                
            }

           


           
                

  

        }
    }

}

 


