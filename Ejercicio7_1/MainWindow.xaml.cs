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

namespace Ejercicio7_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Hacer el programa que calcula el promedio, calificación máxima
            y mínima de un salón de clases usando el ArrayList. */
        public MainWindow()
        {
            InitializeComponent();
        }
        
        ArrayList lista = new ArrayList();
        private int estudiantes = 1;

        private void GuardarButton_Click(Object sender, RoutedEventArgs e)
        {
            lista.Add(float.Parse(NotaTextBox.Text));
            NotaTextBox.Text = "";
            estudiantes++;
            NumeroEstudiante.Text = Convert.ToString(estudiantes);
        }

        private void LimpiarButton_Click(Object sender, RoutedEventArgs e)
        {
            lista.Clear();
            estudiantes = 0;
            NumeroEstudiante.Text = "1";
            NotaMayorTextBox.Text = "";
            NotaMenorTextBox.Text = "";
            PromedioTextBox.Text = "";
        }

        private void CalcularButton_Click(Object sender, RoutedEventArgs e)
        {
            int resultado = 0, mayor = Convert.ToInt32(lista[1]), menor = Convert.ToInt32(lista[1]);
            foreach (var item in lista)
            {
                resultado = resultado + Convert.ToInt32(item);

                if(Convert.ToInt32(item) > mayor) 
                    mayor = Convert.ToInt32(item);
                if(Convert.ToInt32(item) < menor)
                    menor = Convert.ToInt32(item);
            }

            NotaMayorTextBox.Text = Convert.ToString(mayor);
            NotaMenorTextBox.Text = Convert.ToString(menor);
            PromedioTextBox.Text = Convert.ToString(resultado/estudiantes);
        }
    }
}
