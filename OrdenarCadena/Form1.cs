using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cadena = txtCadenaOriginal.Text.Trim();
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Ingresa la cadena de nombres");
                return;
            }

            String[] nombres = cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lstTodosNombre.Items.Clear();
            foreach (String nombre in nombres)
            {
                lstTodosNombre.Items.Add(nombre);
            }

            txtTotalNombres.Text = lstTodosNombre.Items.Count.ToString();
        }


        private void btnPasar_Click(object sender, EventArgs e)
        {
            String letraFiltro = txtLetraFiltro.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(letraFiltro))
            {
                MessageBox.Show("Ingresa la letra de filtro");
                return;
            }
            lstNombresFiltrados.Items.Clear();
            foreach(var item in lstTodosNombre.Items)
            {
                String nombreActual = item.ToString();
                if (nombreActual.ToUpper().StartsWith(letraFiltro))
                {
                    lstNombresFiltrados.Items.Add(nombreActual);
                }
            }
        }

        private void txtLetraFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadenaOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalNombres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
