using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ09
{
    public partial class frmNumeros : Form
    {
        public frmNumeros()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calcular(object sender, EventArgs e)
        {
            Numerosxy n;
            n = new Numerosxy();
            n.setXnumero(int.Parse(txtNumerox.Text));
            n.setYnumero(int.Parse(txtNumeroy.Text));
            n.calcularValores();

            lblResultado.Text = n.getValores().ToString();

        }
    }
}
