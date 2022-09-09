// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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