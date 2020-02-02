using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Saldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valSaque = 10.0;
            saldo -= valSaque;
            MessageBox.Show("O saldo da sua conta é: R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
