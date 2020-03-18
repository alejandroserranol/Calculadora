using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //aquí declaro las variables de instancia

        //operando1 guardará el primer número
        double operando1 = 0;
        /*en el string operacion guardo la operacion
        que ha sido pulsada*/
        String operacion = "";




        public Form1()
        {
            InitializeComponent();
        }

        private void numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (display.Text == "0")
            {
                display.Text = boton.Text;
            }
            else
            {
                display.Text = display.Text + boton.Text;
            }
        }

        private void operacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(display.Text);
            display.Text = "0";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(display.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-") {
                resultado = operando1 - operando2;
            }

            display.Text = Convert.ToString(resultado);
        }
    }
}
