using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1
{
    public class Club
    {
        private List<Socio> socios;

        public Club(List<Socio> socios)
        {
            this.socios = socios;
        }

        public void ImprimirSocioMasAntiguo()
        {
            if (socios.Count > 0)
            {
                Socio socioConMayorAntiguedad = socios.OrderByDescending(s => s.Antiguedad).First();
                Console.WriteLine("El socio mas antiguo en el club es: " + socioConMayorAntiguedad.Nombre);
            }
            else
            {
                Console.WriteLine("El club no tiene socios.");
            }
        }

    }
}
