using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaResumen6
{
    internal class Empleado : Persona
    {
        private double _sueldo;

        public double Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public override void Imprimir()
        {
            base.Imprimir();

            Console.WriteLine($"El sueldo es: {Sueldo}");
        }

    }
}
