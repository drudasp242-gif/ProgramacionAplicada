using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double .TryParse(this.txtIngreso.Text,out double ingreso))
            {
                MessageBox.Show("Ingrese un valor válido para el ingreso.");
                return;
            }

            double fonavi = 0;
            double afp = 0;
            double impRenta = 0;

            if (checkFonavi.Checked)
            {
                fonavi = ingreso * 0.08; // 8% del ingreso
            }
            if (checkImpRenta.Checked)
            {
                impRenta = ingreso * 0.5; // 5% del ingreso
            }
            if (checkAFP.Checked)
            {
                afp = ingreso * 0.12; // 12% del ingreso
            }

            txtResFonavi.Text = fonavi.ToString("C2");
            txtResImp.Text = impRenta.ToString("C2");
            txtResAFP.Text = afp.ToString("C2");
        }
    }
    }

