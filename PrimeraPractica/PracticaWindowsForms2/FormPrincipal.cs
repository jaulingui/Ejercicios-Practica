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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType()==typeof(Form1))
                    return;
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form2))
                    return;
            }

            Form2 ventana2 = new Form2();
            ventana2.MdiParent = this;
            ventana2.Show();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form3))
                    return;
            }

            Form3 ventana3 = new Form3();
            ventana3.MdiParent = this;
            ventana3.Show();
        }
        
    }
}
