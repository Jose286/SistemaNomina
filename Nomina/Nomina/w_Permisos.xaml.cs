﻿using System;
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
    /// Lógica de interacción para w_Permisos.xaml
    /// </summary>
    public partial class w_Permisos : Window
    {
        NominaEntities datos;
        public w_Permisos()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }        
        private void CargarPermisos()
        {
            try
            {
                dgPermisos.ItemsSource = datos.Permisos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPermisos_Loaded(object sender, RoutedEventArgs e)
        {
            CargarPermisos();
        }
    }
}
