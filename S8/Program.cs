// Задача 62. Напишите программу, которая заполнит спирально массив M на N.

int[,] SpiralArray()
{
     Console.WriteLine("Input the rows of the array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] spiral = new int[rows, columns];
    int z = 0;
    int j = 0;
    int i = 0;
    int k = 0;

    while( z < rows*columns-1)
    {
    for( j = k; j < spiral.GetLength(1)-1-k; j++)
    {
       z++;
       spiral[i,j] = z;
    }
    for( i = k; i < spiral.GetLength(0)-1-k; i++)
    {
        z++;
       spiral[i,j] = z;
    }
    for( j = spiral.GetLength(1)-1-k; j > k; j--)
    {
        z++;
       spiral[i,j] = z;
    }
    for( i = spiral.GetLength(0)-1-k; i >= k+1; i--)
    {
        z++;
       spiral[i,j] = z;
    }
    i++;
    k++;
    }
    if(rows*columns%2 !=0) spiral[rows/2,columns/2] = rows*columns;
    return spiral;
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

int[,] array = SpiralArray();
Print2DArray(array);