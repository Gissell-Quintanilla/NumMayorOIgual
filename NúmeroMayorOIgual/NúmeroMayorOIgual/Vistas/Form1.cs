using NúmeroMayorOIgual.Entidades;
using NúmeroMayorOIgual.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NúmeroMayorOIgual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjec_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtNumero1.Text);
            int n2 = Convert.ToInt32(txtNumero2.Text);

            Numeros num = new Numeros(n1, n2);

            Logica log = new Logica();
            String r = log.NMayorOIgual(num);
            lblRes.Text = r;
        }
    }
}
