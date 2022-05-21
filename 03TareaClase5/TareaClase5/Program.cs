while (true)
{
    Console.Clear();

    Console.WriteLine("Ingrese a continuación su nombre:");
    string nombreIngresado;
    nombreIngresado = Console.ReadLine();

    Console.WriteLine($"Hola {nombreIngresado}");

    Console.WriteLine("¿Quieres continuar? S/N");
    string respuesta;
    respuesta = Console.ReadLine().ToUpper();

    if (respuesta == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
        break;
    }
    else if (respuesta != "N" && respuesta != "S")
    {
        Console.WriteLine("Opción no válida");
        break;
    }
    else if (respuesta == "S")
    {

    }
}
    

