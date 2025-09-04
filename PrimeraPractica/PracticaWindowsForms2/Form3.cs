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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;

            try
            {
                a = int.Parse(txtNumUno.Text);
                b = int.Parse(txtNumDos.Text);
                r = a / b;
                lblResultado.Text = "Resultado = " + r;
            }
            catch (FormatException ex)
            {
                lblResultado.Text = "ERROR: Solo cargar número";
            }
            catch (OverflowException ex)
            {
                lblResultado.Text = "ERROR: Número muy largo para mostrar";
            }
            catch (DivideByZeroException ex)
            {
                lblResultado.Text = "ERROR: No se puede dividir por cero";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "ERROR: Motivo no contemplado";
            }
                
        }
    }
}
