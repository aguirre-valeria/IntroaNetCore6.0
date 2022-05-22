// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// PUNTOS IMPORTANTES
    //1. en C# siempre hay que declarar todo
    //2. Con F10 puedes avanzar renglón a renglón la ejecución
    //3. Con F5 puedes dar play a la ejecución del programa
    //4. Las palabras en AZUL, son palabras reservadas, que no pueden utilizarse para darle nombre a una variable

// DEPURACIÓN
    //Se realiza colocando un punto en la línea del código que quieres que termine la depuración, para ver si te larga error o no


// CONSTANTES Y VARIABLES
    //CONSTANTES
        const string constanteTexto = "Esto es una constante";
    //VARIABLES
        byte nro_byte = 0;
            //Las variables pueden modificar su valor, mientras se va ejecutando el programa
                //Nombre de la variable | Nuevo valor | ;
                nro_byte = 1;
            //Las variables no pueden ser repetidas, largará subrayado en rojo si está declarada anteriormente

    //¿Cuándo usar constante y cuándo usar variable?
        //Se usa constante cuando sabemos que el significado del valor no va a cambiar, ejemplo texto, contraseña, valor fijo, etc. En cambio, si creemos que cambiará se utiliza variable.
        //La constante se agrega adelante de la variable, para convertirla en constante: const variable



//TIPOS DE DATOS
    //Tipo de dato | Nombre para la variable | Valor | ; 
        // 1. El tipo de escritura del nombre de la variable puede ser diverso, pero no debe de empezar con un número
        // 2. El punto y coma debe de ir siempre al final cuando se declara una variable
        // 3. El nombre de la variable debe de ser entendible
        // 4. Si el nombre de la variable está subrayado es porque todavía no ha sido utilizada en el código

    // DATOS NUMÉRICOS
        byte numero_byte = 0;
        int numero_integer = 1234;
        long numero_long = 200;
        double numero_double = 300;
        decimal numero_decimal = 0;
        float numero_float = 400;
            //DIFERENCIA ENTRE DOUBLE, FLOAT Y DECIMAL:
                // La diferencia está en la precisión.
                // El double y float se guarda internamente de un modo que no ocupa tanto lugar en la memoria, pero puede que no se guarde exactamente, puede variar en algunos decimales.
                // En cambio los decimales, se guardan exactamente como uno quiere, tienen mayor precisión, pero ocupan mas espacio en memoria
                // En otras palabras: El FLOAT te acorta los números largos (precisión simple), en cambio el DECIMAL te los coloca tal cual son.
                // El DOUBLE es de doble precisión
                    float numero1 = 3.12345678901234567890f;
                    decimal numero2 = 3.12345678901234567890m;
                    double numero3 = 3.12345678901234567890;
                //Ver en consola cómo se ven los diferentes números:
                    Console.WriteLine("El número 1 es " + numero1);
                    Console.WriteLine("El número 2 es " + numero2);
                    Console.WriteLine("El número 3 es " + numero3);

    // DATOS LÓGICOS
        bool datoBool = false;
        // El false también se puede traducir a 0 (apagado) y el true a 1 (prendido)

    // DATOS DE TEXTO
        string datoString = "Texto de prueba";
// Aquí el valor se debe de declarar entre comillas
// Para este lenguaje es importante respetar string con la primera letra en minúscula, para no confundir que se quiere agregar un tipo de dato



// INSTRUCCIONES DE SALIDA Y ENTRADA
    //Instrucción de ENTRADA - INPUT
        //Espera a que escriban en consola y acciona cuando dan ENTER
            Console.ReadLine();
        //Es importante generar una variable para guardar lo que escribe el usuario en algún lado
            string nombre;
            nombre = Console.ReadLine();
        //Para convertir una entrada en número se utiliza:
            string numeroString = Console.ReadLine();
            int numeroInteger = Convert.ToInt32(numeroString);
        //Otra forma de convertir es a través de PARSE
            int.Parse(Console.ReadLine());
    
    //Instrucción de SALIDA - OUTPUT
        //Escribe una línea en consola pero NO pasa a la siguiente línea (no hace salto de línea), por lo que, lo que se escriba luego seguirá a lo de aquí
            Console.Write("Hola por primera vez");
        //Escribe una línea en consola y pasa a la siguiente línea
            Console.WriteLine("Hola, Ingrese su nombre");
            Console.WriteLine(numero_integer);



// BORRA LA PANTALLA DE LA CONSOLA
Console.Clear();

// EJECUTAR UNA TECLA
    Console.ReadKey();


// CONDICIONALES
    //Es una instrucción o grupo de instrucciones que pueden ejecutarse o no en función del valor de una condición.

    // IF (si)
        // La sentencia if («si») ejecuta las instrucciones sólo si se cumple una condición. Si la condición es falsa, no se hace nada.

    // IF ELSE (si..sino)
        // La sentencia if-else («si o sino») decide qué instrucciones ejecutar dependiendo si una condición es verdadera o falsa

    // SWITCH CASE (según)
        // Compara el valor de una variable o el resultado de evaluar una expresión, con un conjunto de valores valor1, valor2, valor3, .., cuando coinciden ejecuta el bloque de sentencias que están asociadas. Si no existe coincidencia, se ejecuta la sentencia default, si es que está presente en el código.


// OPERADORES LÓGICOS
    /* 
        AND -> && (Y)
        OR -> || (O)
        Igual que -> ==
        Distinto que -> !=
    */

//PARA CAMBIAR A MAYÚSCULA O MINÚSCULAS
    // MAYÚSCULAS
        // texto.ToUpper()
    // MINÚSCULA
        // texto.ToLower()



// CICLOS: WHILE Y FOR
    // WHILE
        //Pregunta la condición y luego deja entrar al ciclo
        //Mientras se cumpla la condición, vamos a dar la vuelta del ciclo de forma infinita
        //Se usa cuando NO sabemos cuántas vueltas al ciclo se va a dar

    // DO WHILE
        //Entra al ciclo directo y luego pregunta la condición

    // FOR
        //Para, mientras que ...
        //Se usa cuando SÍ sabemos cuántas vueltas al ciclo se va a dar
            //for(declaración; condicion; aumento)

// MATRICES (o ARRAYS en otros lenguajes)
    //Se utilizan para almacenar múltiples valores en una sola variable, en lugar de declarar variables separadas para cada valor.
    //Es como si se pudiera guardar cosas dentro de una variable del mismo tipo
    //Array proviene de la formación de vagones de un tren
    //Para declarar una matriz, se define el tipo de variable con corchetes:
        // string[] cars;
    //Para insertarle valores sería de la siguiente manera para texto o para números:
        string[] cars = {"Volvo","BMW","Ford","VW"};
        int[] misNumeros = { 10, 20, 30, 40 };
    //Para acceder a un valor de la matriz, se llama a la variable y luego entre corchetes va el índice, es decir, el valor dentro de la variable que se quiere
        Console.WriteLine(cars[0]);

string[] Frutas = new string[1];

Frutas[0] = "Pera";

// DIFERENCIA ENTRE CONTADOR Y ACUMULADOR
    //Las dos cosas son variables comunes, solo que guardan cosas diferentes
        // CONTADOR
            //Guarda en la variable las veces que pasa. Es decir, incrementa en un valor constante (de a 1 o de a 2 o lo que se requiera)
        // ACUMULADOR
            //Guarda en la variable las sumatorias, multiplicaciones, etc de los valores que no son fijos. Es decir, incrementa en cantidades diferentes.
