using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio7_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Hacer un programa que funcione como una agenda telefónica
            y que guarde el nombre de la persona y su número telefónico. */
        public MainWindow()
        {
            InitializeComponent();
        }

        Hashtable tabla = new Hashtable();

        private void GuardarButton_Click(Object sender, RoutedEventArgs e)
        {
            tabla.Add(NombreTextBox.Text, NumeroTextBox.Text);

            if(tabla.Contains(NombreTextBox.Text))
                MessageBox.Show("El registro se a guardado.");
            else
                MessageBox.Show("El registro no se a guardado.");
        }

        private void BuscarButton_Click(Object sender, RoutedEventArgs e)
        {
            if(tabla.Contains(NombreTextBox.Text))
            {
                ResultadoTextBox.Text = NombreTextBox.Text + " " + tabla[NombreTextBox.Text];
            }
            else
            {
                MessageBox.Show("Este registro no existe.");
            }
        }
    }
}
