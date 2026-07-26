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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calcular_Temperaturas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_MostrarCalculos_Click(object sender, RoutedEventArgs e)
        {
            String[] meses ={
                "Enero", "Febrero","Marzo", "Abril","Mayo","Junio",
                "Julio", "Agosto", "Septiembre","Octubre","Noviembre","Diciembre"
            };

            TextBox[] camposTexto ={
                txtEnero, txtFebrero, txtMarzo, txtAbril, txtMayo, txtJunio,
                txtJulio, txtAgosto, txtSeptiembre, txtOctubre, txtNoviembre, txtDiciembre
            };

            double[] temperaturas = new double[12];
            double suma = 0;

            for(int i = 0; i< 12; i++)
            {
                if (double.TryParse(camposTexto[i].Text, out double temp))
                {
                    temperaturas[i] = temp;
                    suma += temp;
                }
                else
                {
                    MessageBox.Show($"Por favor ingresa una temperatura válida para {meses[i]}.", "Error de entrada", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }

            double promedio = suma / 12;
            txtPromedio.Text = Math.Round(promedio, 2).ToString("0,00");

            lstTemperaturas.Items.Clear();
            int contadorMayores = 0;

            for(int j = 0; j < 12; j++){
                if (temperaturas[j] > promedio)
                {
                    contadorMayores++;
                    lstTemperaturas.Items.Add(meses[j]);
                }
            }


        }
    }   
}
