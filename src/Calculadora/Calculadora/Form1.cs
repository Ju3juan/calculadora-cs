using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private ControladorCalculadora calcControlador;

        public Form1()
        {
            InitializeComponent();
            calcControlador = new ControladorCalculadora();
        }

        // Números
        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calcControlador.AgregarNumero(lblDisplay.Text, "9");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!lblDisplay.Text.Contains("."))
            {
                lblDisplay.Text += ".";
            }
        }
        
        // operadores 

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double numeroActual = double.Parse(lblDisplay.Text);
            string operacion = calcControlador.ProcesarOperador(numeroActual, "+");
            lblOperacion.Text = operacion.Replace("+", "+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double numeroActual = double.Parse(lblDisplay.Text);
            string operacion = calcControlador.ProcesarOperador(numeroActual, "+");
            lblOperacion.Text = operacion.Replace("-", "-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numeroActual = double.Parse(lblDisplay.Text);
            string operacion = calcControlador.ProcesarOperador(numeroActual, "+");
            lblOperacion.Text = operacion.Replace("*", "*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numeroActual = double.Parse(lblDisplay.Text);
            string operacion = calcControlador.ProcesarOperador(numeroActual, "+");
            lblOperacion.Text = operacion.Replace("/", "/");
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            // TODO: Implementar funcionalidad de cambio de signo
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {

        }

        // igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado = calcControlador.ProcesarIgual(double.Parse(lblDisplay.Text));
            lblDisplay.Text = resultado.ToString();
            lblOperacion.Text = "";
        }

        // limpieza y historil 

        private void btnC_Click(object sender, EventArgs e)
        {
            calcControlador.Reset();
            lblDisplay.Text = "0";
            lblOperacion.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            calcControlador.EstaEscribiendoNumero = false;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 1)
            {

                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1);
            }
            else
            {
                lblDisplay.Text = "0";
            }
        }

        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            ToggleHistorial();
        }

        private void ToggleHistorial()
        {
            bool mostrar = !this.pnlHistorial.Visible;

            this.pnlHistorial.Visible = mostrar;
            this.pnlHistorial.Location = new Point(9, 169);

            if (mostrar)
            {
                this.pnlHistorial.BringToFront();
            }
            else
            {
                this.pnlHistorial.SendToBack();
            }
        }
    }
}
