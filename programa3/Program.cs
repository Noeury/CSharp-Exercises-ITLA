// See https://aka.ms/new-console-template for more information

using programa3;

Dado dado1 = new();

Dado dado2 = new();

Dado dado3 = new();

bool continuar = true;
string respuesta = "";

intentarLanzamiento();

void intentarLanzamiento()
{
    while (continuar)
    {
        dado1.lanzarDado();
        dado2.lanzarDado();
        dado3.lanzarDado();

        Console.WriteLine("Lanzando dados...");

        if ((dado1.Resultado == dado2.Resultado) && (dado1.Resultado == dado3.Resultado))
        {
            Console.WriteLine("Ganaste con estos valores {0}, {1}, {2}", dado1.Resultado, dado2.Resultado, dado3.Resultado);

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Perdiste con estos valores {0}, {1}, {2}", dado1.Resultado, dado2.Resultado, dado3.Resultado);
        }
        Console.WriteLine("Deseas jugar otra vez? (y/N)");
        respuesta = Console.ReadLine();

        if (respuesta == "y" | respuesta == "Y")
        {
            continuar = true;
        }
        else
        {
            continuar = false;
        }

    }




}