// See https://aka.ms/new-console-template for more information
using programa1;


List<Socio> listaDeSocios = new List<Socio>
        {
            new Socio("Juan", 3),
            new Socio("Pedro", 5),
            new Socio("Carlos", 2)
        };

Club club = new Club(listaDeSocios);

club.ImprimirSocioMasAntiguo();

Console.ReadKey();