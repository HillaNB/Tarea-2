// See https://aka.ms/new-console-template for more information

int n = 2;
int[,] matriz = new int[n, n]; // Matriz
int sumaD = 0; // Variable para la suma de la diagonal
Random rand = new Random();

for (int f = 0; f < n; f++) // Filas
{
    for (int c = 0; c < n; c++) // Columnas
    {
        matriz[f, c] = rand.Next(1, 10); // Random
        if (f + c == n - 1) // Diagonal
        {
            sumaD += matriz[f, c]; // Suma diagonal
        }
    }
}

for (int i = 0; i < n; i++) //Imprime matriz
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"  {matriz[i, j]}");
    }
    Console.WriteLine();
}

Console.WriteLine($"La suma de la diagonal es: {sumaD}");

Console.ReadLine();



-------------------------------------------

//// See https://aka.ms/new-console-template for more information

//int[] numeros = new int[5];
//int[,] matriz = new int[5, 5]; //Matriz

//int sumaE = 0;
//int valor = 1;
//Random rand = new Random();

//for (int f = 0; f < 5; f++) // Filas
//{
//    for (int c = 0; c < 5; c++) // Columnas
//    {
//        matriz[f, c] = rand.Next(1, 100); // Random
//        if ((f == 0 || f == 4) && (c == 0 || c == 4))
//        {
//            sumaE += matriz[f, c]; //Acumulador
//        }
//    }
//}

//// Imprimir la matriz
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write($"  {matriz[i, j]}");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine($"Sumatoria de las esquinas: {sumaE}");

//Console.ReadLine();
