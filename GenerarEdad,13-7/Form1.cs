using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarEdad_13_7
{
    public partial class Form1 : Form
    {
        private int edadMinima;
        private int edadMaxima;
        private int edadPropuesta;
        private int contadorIntentos;

        private Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(contadorIntentos == 0)
            {
                MessageBox.Show("Debe hacer click en el boton primer intento");
                return;
            }
            edadPropuesta = random.Next(edadMinima, edadMaxima + 1);
            contadorIntentos++;
            txtMostrarEdad.Text = edadPropuesta.ToString();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRango1.Text, out edadMinima))
            {
                MessageBox.Show("Ingrese una edad minima Valida", "Validacion!", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
            }
            if (!int.TryParse(txtRango2.Text, out edadMaxima))
            {
                MessageBox.Show("Ingrese una edad máxima Valida", "Validacion!", MessageBoxButtons.OK,MessageBoxIcon.Error);return;
            }
            if(edadMinima >= edadMaxima)
            {
                MessageBox.Show("La edad minima debe ser menor a la edad maxima", "Validacion!", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            edadPropuesta = random.Next(edadMinima, edadMaxima + 1);
            contadorIntentos++;
            txtMostrarEdad.Text = edadPropuesta.ToString();
        }

        private void btnCorrecto_Click(object sender, EventArgs e)
        {
            if (contadorIntentos == 0)
            {
                MessageBox.Show("Debe hacer click en el boton primer intento");
                return;
            }
            MessageBox.Show("¡Felicidades! Has acertado la edad propuesta:" + edadPropuesta, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
