using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplosDeTres
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<int> listaMultiplos = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    listaMultiplos.Add(i);
                }


            }
            foreach (var item in listaMultiplos)
            {
                sb.AppendLine(item.ToString());
            }

            MessageBox.Show("Multiplos de 3: \n" + sb);
        }
    }
}
