using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.Entities
{
    class Account
    {
        
        public int Id { get; set; }
        public string Owner { get; set; }
        public double Saldo { get; private set; }

        public Account()
        {

        }

        public Account(int id, string owner, double saldo)
        {
            Id = id;
            Owner = owner;
            Saldo = saldo;
        }

        public void Withdraw(double value)
        {
            if (Saldo >= value )
            {
                Saldo -= value;
            }
        }

        public void Deposit(double value)
        {
            Saldo += value;
        }
    }
}
