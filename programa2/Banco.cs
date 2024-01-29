using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2
{
    public class Banco
    {

        private List<Cliente> clientes = new List<Cliente>();
        public Banco() { }

        public Banco(List<Cliente> clientes)
        {
            this.clientes = clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void AgregarVariosClientes(List<Cliente> nuevosClientes)
        {
            clientes.AddRange(nuevosClientes);
        }


        public decimal calularBalance()
        {
            return clientes.Select(x => x.Cuenta.Balance).Sum();
        }


    }
}
