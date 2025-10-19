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
        public Form1()
        {
            InitializeComponent();

            this.pnlHistorial.BringToFront();
            this.pnlHistorial.Location = new Point(9, 169);
        }
        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            ToggleHistorial();
        }
        private void ToggleHistorial()
        {
            bool mostrar = !this.pnlHistorial.Visible;
            
            switch (mostrar)
            {
                case true:
                    this.pnlHistorial.Visible = mostrar;
                    this.pnlHistorial.BringToFront();
                    break;

                case false:
                    this.pnlHistorial.Visible = mostrar;
                    this.pnlHistorial.SendToBack();
                    break;

            }
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MathGen()
        {

        }
        private void DisplayCheck()
        {
        }
        private void lblDisplay_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "/";
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "^2";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text += "v()";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lblDisplay.Text.Length - 1;
            int count = 1;
            this.lblDisplay.Text = this.lblDisplay.Text.Remove(index, count);

            if (String.IsNullOrEmpty(lblDisplay.Text) || String.IsNullOrWhiteSpace(lblDisplay.Text))
            {
                this.lblDisplay.Text = "0";
                return;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "CE";
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "(-)";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "=";
        }
    }
}

