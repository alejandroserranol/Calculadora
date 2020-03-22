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
    public partial class exp : Form
    {
        //aquí declaro las variables de instancia

        //operando1 guardará el primer número
        double operando1 = 0;
        /*en el string operacion guardo la operacion
        que ha sido pulsada*/
        String operacion = "";
        String accion = "";




        public exp()
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
                if (boton.Text != ".")
                {
                    display.Text = display.Text + boton.Text;
                }
                else if (boton.Text == "." && !display.Text.Contains('.'))
                {
                    display.Text = display.Text + boton.Text;
                }
            }
        }

        private void operacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            if (display.Text.Contains('.'))
            {
                int posicion = display.Text.IndexOf('.');
                double resultadoSinOperacion = Convert.ToDouble(display.Text);
                resultadoSinOperacion /= (10 * (posicion));
                operando1 = resultadoSinOperacion;
            }
            else
            {
                operando1 = Convert.ToDouble(display.Text);
            }
            display.Text = "0";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                if (display.Text.Contains('.'))
                {
                    int posicion = display.Text.IndexOf('.');
                    double resultadoSinOperacion = Convert.ToDouble(display.Text);
                    resultadoSinOperacion /= (10 * (posicion));
                    display.Text = Convert.ToString(resultadoSinOperacion);
                }
                else
                {
                }
                double operando2 = Convert.ToDouble(display.Text);
                double resultado = 0;
                if (operacion == "+")
                {
                    resultado = operando1 + operando2;
                }
                else if (operacion == "-")
                {
                    resultado = operando1 - operando2;
                }
                else if (operacion == "/")
                {
                    resultado = operando1 / operando2;
                }
                else if (operacion == "*")
                {
                    resultado = operando1 * operando2;
                }
                else if (operacion == "^")
                {
                    resultado = Math.Pow(operando1, operando2);
                }
                else if (operacion == "¬")
                {
                    resultado = Math.Pow(operando1, 1.0 / operando2);
                }
                else if (operacion == "log")
                {
                    resultado = Math.Log(operando1, operando2);
                }
                display.Text = Convert.ToString(resultado);
            }
        }

        private void otroBoton_Click(object sender, EventArgs e)
        {
            Button otro_boton = (Button)sender;
            accion = otro_boton.Text;
            if(accion == "AC")
            {
                display.Text = "0";
            } 
            else if(accion == "DEL")
            {
                if(display.Text.Length > 1)
                {
                    display.Text = display.Text.Remove(display.Text.Length-1, 1);
                }
                else if(display.Text.Length == 1 && display.Text != "0")
                {
                    display.Text = "0";
                }
            }
            else if (accion == "x2")
            {
                double resultado = Convert.ToDouble(display.Text);
                resultado *= resultado;
                display.Text = Convert.ToString(resultado);
            }
            else if (accion == "-")
            {
                double resultado = Convert.ToDouble(display.Text);
                resultado *= -1;
                display.Text = Convert.ToString(resultado);
            }
            else if (accion == "ln")
            {
                double resultado = Convert.ToDouble(display.Text);
                resultado = Math.Log(resultado, Math.E);
                display.Text = Convert.ToString(resultado);
            }
            else if (accion == "sin")
            {
                double resultado = Convert.ToDouble(display.Text);
                resultado = Math.Sin(resultado);
                display.Text = Convert.ToString(resultado);
            }
            else if (accion == "cos")
            {
                double resultado = Convert.ToDouble(display.Text);
                resultado = Math.Cos(resultado);
                display.Text = Convert.ToString(resultado);
            }
            else if (accion == "tan")
            {
                double resultado = Convert.ToDouble(display.Text);
                resultado = Math.Tan(resultado);
                display.Text = Convert.ToString(resultado);
            }

        }
    }
}
