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
