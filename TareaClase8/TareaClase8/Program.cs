// Ingreso por pantalla de valores para el tamaño de filas y columnas
Console.WriteLine("Ingrese cuántas filas desea: ");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cuántas columnas desea: ");
int columnas = int.Parse(Console.ReadLine()); 

// Matriz de dos dimensiones de tipo int llamada números
int[,] numeros = new int[filas,columnas];

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

Console.WriteLine();

// Carga de valores a la matriz (con elementos de tipo int)
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine(); 
    Console.WriteLine($"Columna n° {columna + 1}: ");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Ingrese el valor para la fila n° {fila + 1}: ");
        numeros[fila,columna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

// Recorrido de matriz e impresión de los valores en pantalla
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine(); 
    Console.WriteLine($"Valores de la columna n° {columna + 1}: ");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"El valor de la fila n° {fila + 1} es: ");
        Console.WriteLine (numeros[fila, columna]);
    }
}

Console.WriteLine();


// Cálculo del promedio de cada columna / Impresión en pantalla
double suma = 0;
double promedios = 0;
for (int columna = 0; columna < lengthColumnas; columna++)
{
    suma = 0;
    promedios = 0;
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        suma = suma + numeros[fila, columna];
    }
    promedios = suma / lengthFilas;
    Console.WriteLine($"El promedio de la columna n° {columna +1} es: {promedios}");
}
