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
            ConfigurarBotones();

        }
        private void ConfigurarBotones()
        {
            btnSuma.Text = "\uE948";
            btnMultiplicar.Text = "\ue947";
            btnResta.Text = "\uE949";
            btnDividir.Text = "\uE94A";
            btnRaiz.Text = "\uE94B";
            btnNegativo.Text = "\uE94D";
            btnIgual.Text = "\uE94E";
            btnDel.Text = "\uE94F";
            btnCuadrado.Text = "x\u00B2";
            btnMostrarHistorial.Text = "\uf738";
        }

        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            ToggleHistorial();
        }
        private void ToggleHistorial()
        {
            bool mostrar = !pnlHistorial.Visible;
            pnlHistorial.Visible = mostrar;
            pnlHistorial.Location = new Point(9, 169);
        }
    }
}
