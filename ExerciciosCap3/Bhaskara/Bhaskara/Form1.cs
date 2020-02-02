using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tba.Text != "" && tbb.Text != "" && tbc.Text != "")
            {
                double a = double.Parse(tba.Text);
                double b = double.Parse(tbb.Text);
                double c = double.Parse(tbc.Text);

                double delta = (Math.Pow(b, 2) - 4 * a * c);
                if (delta > 0)
                {
                    double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    MessageBox.Show("O valor das raizes são: \nx1 = " + a1 + "\nx2 = " + a2);
                }
                else
                {
                    MessageBox.Show("Não é possível calcular raiz quadrada de números negativos");
                }
            }
            

        }
    }
}
