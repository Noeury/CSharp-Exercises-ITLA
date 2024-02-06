using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaResumen6
{
    internal class Persona


    {
        private string _nombre;
        private int _edad;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"El nombre es {Nombre} y su edad es {Edad}");
        }
    }
}
