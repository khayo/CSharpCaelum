using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextoEmVariavel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (message == "")
            {
                MessageBox.Show("Nenhum texto foi digitado");
            }
            else
            {
                MessageBox.Show(message);
            }
            
            
        }
    }
}
