using System;
using System.Collections.Generic;
using System.Collections;
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

namespace Ejercicio7_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Hacer un programa que funcione como un diccionario,
            con palabra y definición, usando el Hashtable. */
        public MainWindow()
        {
            InitializeComponent();
        }

        Hashtable tabla = new Hashtable();

        private void GuardarButton_Click(Object sender, RoutedEventArgs e)
        {
            tabla.Add(PalabraTextBox.Text, DescripcionTextBox.Text);

            if(tabla.Contains(PalabraTextBox.Text))
                MessageBox.Show("El registro se a guardado.");
            else
                MessageBox.Show("El registro no se a guardado.");
        }

        private void BuscarButton_Click(Object sender, RoutedEventArgs e)
        {
            if(tabla.Contains(PalabraTextBox.Text))
            {
                ResultadoTextBox.Text = PalabraTextBox.Text + ": " + tabla[PalabraTextBox.Text];
            }
            else
            {
                MessageBox.Show("Este registro no existe.");
            }
        }
    }
}
