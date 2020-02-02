using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleicao
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void button_Verificar_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(textBox_idade.Text);
            bool brasileiro = checkBox_brasileiro.Checked;

            if (idade >= 16 && brasileiro)
            {
                MessageBox.Show("Pode votar!", "Verificado");
            }
            else
            {
                MessageBox.Show("Não pode votar", "Verificado");
            }
        }
    }
}
