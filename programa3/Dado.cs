using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3
{
    internal class Dado
    {
        private int _resultado;
        public int Resultado
        {
            get
            { return _resultado; }
            set
            {
                _resultado = value;
            }
        }


        public int lanzarDado()
        {
            Random number = new Random();
            return Resultado = number.Next(1, 6);
        }

    }
}
