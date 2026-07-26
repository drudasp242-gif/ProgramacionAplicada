using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace TragaMonedas
{
    public partial class Form1 : Form
    {
        private DispatcherTimer timerReloj;
        private DispatcherTimer timerJuego;
        private Random random = new Random();

        private const int TIEMPO_TOTAL_TICKS = 60;
        private int contadorTicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timerJuego.Start();
            contadorTicks = 0;
            lblResultado.Visibility =Visibility.Hidden;
            btnIniciar_Click.isenabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
