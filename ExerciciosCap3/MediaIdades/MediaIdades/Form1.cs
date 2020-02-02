using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeKhayo = 32;
            int idadeJey = 34;
            int idadeRodrigues = 58;
            int media = (idadeJey + idadeKhayo + idadeRodrigues) / 3;

            MessageBox.Show("Média de idade: " + media);
        }
    }
}
