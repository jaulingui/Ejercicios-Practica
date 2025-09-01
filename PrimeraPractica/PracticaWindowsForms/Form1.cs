using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola, soy un botón");
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            if (checkNombre.Checked)
            {
                lblSaludo.Text = "Hola " + nombre + " " + apellido + " , te saludo!";
            }
            else
            {
                lblSaludo.Text = "No se muestran los datos.";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy otro botón");
        }

        private void chekNombre_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
