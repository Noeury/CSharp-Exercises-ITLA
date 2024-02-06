// See https://aka.ms/new-console-template for more information


using programaResumen6;

Persona persona = new();
persona.Nombre = "Noeury";
persona.Edad = 27;

persona.Imprimir();

Console.WriteLine("-------------");

Empleado empleado = new();

empleado.Nombre = "Juan";
empleado.Edad = 30;
empleado.Sueldo = 50000;

empleado.Imprimir();

Console.ReadKey();