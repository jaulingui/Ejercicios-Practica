using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWindowsForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtTexto.Text;
            string fecha = dtmFecha.Text;
            string color;

                if(rbtRojo.Checked)
                {
                color = "Rojo";
                } else if(rbtAzul.Checked)
                {
                color = "Azul";
                } else
                {
                color = "Verde";
                }
            lvElementos.Items.Add(elem);
            lvElementos.Items.Add(fecha);
            lvElementos.Items.Add(color);

            DateTime fecha2 = dtmFecha.Value;

            //string mostrarFecha2 = fecha2.ToString();

            MessageBox.Show(fecha2.ToString());           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPais.Items.Add("Argenina");
            cmbPais.Items.Add("Chile");
            cmbPais.Items.Add("Brasil");
            cmbPais.Items.Add("Uruguay");

        }
    }
}
