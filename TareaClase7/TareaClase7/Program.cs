int [] numeros = new int[9];
int nroMayor = numeros[0];
int nroMenor = numeros[0];
int suma = 0;
float promedio = 0;

Console.WriteLine("A continuación ingresa 10 números:");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingresa un número para el índice: {i}");
    numeros[i] = int.Parse(Console.ReadLine());
    if (numeros[i] > nroMayor)
    {
        nroMayor = numeros[i];
    }
    if (numeros[i] < nroMenor)
    {
        nroMenor = numeros[i];
    }
    suma += numeros[i];
    promedio = suma / numeros.Length;
}

Console.WriteLine();
Console.WriteLine("Los números ingresados fueron:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
Console.WriteLine($"La suma de todos los números ingresados es: {suma}");
Console.WriteLine($"El número mayor es: {nroMayor}");
Console.WriteLine($"El número menor es: {nroMenor}");
Console.WriteLine($"El promedio de todos los números es: {promedio}");
