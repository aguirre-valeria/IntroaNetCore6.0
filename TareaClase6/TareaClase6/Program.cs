int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

Console.WriteLine("Adivina el número que elegió la computadora");
int intentos = 0;

while (true)
{
    Console.WriteLine("Ingresa un número");
    int respuesta = 0;
    respuesta = int.Parse(Console.ReadLine());

    if (respuesta == numeroSecreto)
    {
        intentos++;
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {intentos} intentos");
        break;
    }
    else if (respuesta > numeroSecreto)
    {
        Console.WriteLine("El número ingresado es mayor al número secreto");
        Console.WriteLine("Intenta nuevamente");
        intentos++;
    }
    else if (respuesta < numeroSecreto)
    {
        Console.WriteLine("El número ingresado es menor al número secreto");
        Console.WriteLine("Intenta nuevamente");
        intentos++;
    }
}
