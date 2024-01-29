using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1
{
    public class Socio
    {
        private string nombre;
        private int antiguedad;

        public string Nombre
        {
            get { return nombre; }
        }

        public int Antiguedad
        {
            get { return antiguedad; }
        }

        public Socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }



    }
}
