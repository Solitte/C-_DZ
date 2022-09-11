// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Random2DArray()
{
    Console.WriteLine("Input the rows of the array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the maximum number of the array");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


    double[,] table = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            table[i,j] = Math.Round(new Random().NextDouble()*n,2);
    
    return table;
}

void Print2DArray(double[,] table)
{
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write($"{table[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();   
}

double[,] array = Random2DArray();
Print2DArray(array);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
/*
int[,] Random2DArray()
{
    Console.WriteLine("Input the rows of the array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the minimum number of the array");
    int minElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the maximum number of the array");
    int maxElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            table[i,j] = new Random().Next(minElem, maxElem+1);
    
    return table;
}

void Print2DArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write($"{table[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();   
}

void ScanElementArray(int[,] table)
{
    Console.WriteLine("Input index row to scan for element array");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input index column to scan for element array");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < table.GetLength(0) && n < table.GetLength(1)) Console.WriteLine(table[m,n]);
    else Console.WriteLine("Element not detected");
}

    int[,] array = Random2DArray();
    Print2DArray(array);
    ScanElementArray(array);

*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Random2DArray()
{
    Console.WriteLine("Input the rows of the array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the minimum number of the array");
    int minElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the maximum number of the array");
    int maxElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            table[i,j] = new Random().Next(minElem, maxElem+1);
    
    return table;
}

void Print2DArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write($"{table[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();   
}

void MediumJArray(int[,] table)
{   double sum, mediumj;
    for(int j = 0; j < table.GetLength(1); j++)
    {
     sum = 0;
        for(int i = 0; i < table.GetLength(0); i++) sum += table[i,j];                      
     mediumj = Math.Round(sum/table.GetLength(0),2);   
     Console.Write($"|{j+1} = {mediumj}| ");   
    }
}
int[,] array = Random2DArray();
Print2DArray(array);
MediumJArray(array);
