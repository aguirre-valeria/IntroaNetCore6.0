//1. Pedir al usuario la longitud de un vector
Console.WriteLine("A continuación ingresa cuál será la longitud del vector:");
int longitud = int.Parse(Console.ReadLine()); 

//2. Crear el vector del tamaño ingresado
int[] vector = new int[longitud];

//3. Llenar el mismo con datos aleatorios
Random datosAleatorios = new Random();

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = datosAleatorios.Next(100);
}

Console.WriteLine();

//4. Mostrar el vector por pantalla
Console.WriteLine("Los datos del vector son los siguientes: ");
foreach (int i in vector)
{
    Console.Write(i + " ");
}
Console.WriteLine();

//5. Invertir el vector, de manera que el primer elemento quede al último
//y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el
//segundo y así sucesivamente. En otra palabras si el vector es de 5
//posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido,
//el vector debe quedar así: 50, 40, 30, 20, 10.
//
for (int i = 0; i < vector.Length / 2; i++)
{
    int aux = vector[i];
    int reves = vector.Length - i - 1;
    vector[i] = vector[reves];
    vector[reves] = aux;
}

Console.WriteLine();

//6. Mostrar el vector nuevamente
Console.WriteLine("Los datos del vector son los siguientes: ");
foreach (int i in vector)
{
    Console.Write(i + " ");
}
