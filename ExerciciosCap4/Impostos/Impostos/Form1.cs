using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impostos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = double.Parse(textBoxValorNota.Text);
            double aliquota = 0.0;
            if (valorDaNotaFiscal <= 999)
            {
                aliquota = 2;
            }
            else if (valorDaNotaFiscal >=1000 && valorDaNotaFiscal <= 2999)
            {
                aliquota = 2.5;
            }
            else if (valorDaNotaFiscal >=3000 && valorDaNotaFiscal <= 6999)
            {
                aliquota = 2.8;
            }
            else
            {
                aliquota = 3;
            }

            MessageBox.Show("Aliquita: " + aliquota + "%");
        }
    }
}
