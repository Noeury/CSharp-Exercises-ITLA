using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2
{
    public class Cuenta
    {
        private int numeroCuenta;
        private decimal balance = 0;

        public int NumeroCuenta
        {
            get { return numeroCuenta; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Cuenta(decimal balance)
        {
            this.numeroCuenta = new Random().Next(1000000, 2000000);
            this.balance = balance;
        }

        public bool Depositar(decimal monto)
        {
            balance += monto;
            return true;
        }

        public bool Retirar(decimal monto)
        {
            if (monto > balance)
                return false;

            balance -= monto;
            return true;
        }
    }
}
