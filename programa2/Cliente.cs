using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2
{
    public class Cliente
    {
        private string nombre;
        private Cuenta cuenta;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public Cliente(string nombre, Cuenta cuenta)
        {
            this.nombre = nombre;
            this.cuenta = cuenta;
        }
    }
}
