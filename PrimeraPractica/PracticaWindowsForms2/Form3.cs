using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        //En este caso la acción del botón realiza la operación y valida la excepción
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

        //La interacción en el entorno visual realiza la petición de la acción.
        //Se llama a una función que se encarga de realizar la acción y muestra el resultado, o el error
        private void btnCalcular2_Click(object sender, EventArgs e)
        {

            int resultado;
            try
            {
                resultado = calcular();
                lblResultado2.Text = "Resultado = " + resultado;
            }
            catch (FormatException ex)
            {
                lblResultado2.Text = "ERROR: Solo cargar número";
            }
            catch (DivideByZeroException ex)
            {
                lblResultado2.Text = "ERROR: No se puede dividir por cero";
            }
            catch (OverflowException ex)
            {
                lblResultado2.Text = "ERROR: Número muy largo para mostrar";
            }
            catch (Exception ex)
            {
                lblResultado2.Text = "ERROR: Motivo no contemplado";
            }
            finally
            {
                //instrucciones que se ejecutan aunque haya errores
                //cerrar un archivo, o conexión a base de datos
            }
        }
        //Función llamada por la acción de la interfaz grafica. Realiza la operación y devuelve
        //un valor, o un error para que sea mostrado
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtValorUno.Text);
                b = int.Parse(txtValorDos.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
    }
}
