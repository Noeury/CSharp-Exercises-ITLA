// See https://aka.ms/new-console-template for more information
using programa2;

Banco banco = new Banco();

Console.WriteLine($"El balance inicial en el banco es: {banco.calularBalance()}");

Cliente cliente1 = new Cliente("Juan", new Cuenta(500));
Cliente cliente2 = new Cliente("Pedro", new Cuenta(700));
Cliente cliente3 = new Cliente("Carlos", new Cuenta(800));

cliente1.Cuenta.Depositar(50000);
cliente2.Cuenta.Depositar(50000);
cliente3.Cuenta.Depositar(50000);

cliente1.Cuenta.Retirar(12000);
cliente2.Cuenta.Retirar(3200);
cliente3.Cuenta.Retirar(1500);

List<Cliente> clientes = new List<Cliente> { cliente1, cliente2, cliente3 };

banco.AgregarVariosClientes(clientes);

Console.WriteLine($"El balance en el banco es: {banco.calularBalance()}");





Console.ReadKey();
