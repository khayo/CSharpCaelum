using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conta.Entities;
using System.Globalization;

namespace Conta
{
    public partial class Form1 : Form
    {
        private Account acc { get; set; }
        public Form1()
        {
            InitializeComponent();
            acc = new Account(1, "Vitor", 100.00);
            labelConta.Text = "Conta: " + acc.Id;
            labelOwner.Text = "Titular: " + acc.Owner;
        }

        private void buttonSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo: R$" + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture), "Saldo");
        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            acc.Withdraw(double.Parse(textBoxValor.Text));
            MessageBox.Show("Saque efetuado! /nSaldo: R$" + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture), "Confirmação");
        }

        private void buttonDeposito_Click(object sender, EventArgs e)
        {
            acc.Deposit(double.Parse(textBoxValor.Text));
            MessageBox.Show("Depósito efetuado com sucesso", "Confirmação");
        }

    }
}
