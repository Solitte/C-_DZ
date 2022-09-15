// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] Sorting2DArray(int[,] table)
{   
    
    int max = 0;
    int j = 0;
    int m = 0;
    int n = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for(int count = 0; count < table.GetLength(1);count++)
        {
            max = table[i,count];
            for ( j = count; j < table.GetLength(1); j++)
            {
                if(table[i,j] > max)
                {
                    max = table[i,j];
                    n = i;
                    m = j;
                }
            }
            if (max!=table[i,count])
            {
                table[n,m] = table[i,count];
                table[i,count] = max;
            }

        }
    }
return table;
}

int[,] array = Random2DArray();
Print2DArray(array);
int[,] arr = Sorting2DArray(array);
Print2DArray(arr);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumMinElemArray(int[,] table)
{ 
    int m = 0;
    int minsum = 0 ;  
    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum = sum + table[i,j];
        }
        if(i == 0)
        {
            minsum = sum;
            m = i;
        }
        if(sum < minsum)
        {
            minsum = sum;
            m = i;
        }
    }
    Console.WriteLine($"Minimum sum of elements: {minsum}");
    return m;   
}

int[,] array = Random2DArray();
Print2DArray(array);
int row = SumMinElemArray(array);
Console.WriteLine($"Row with minimum sum of elements: {row}");


// Задача 62. Напишите программу, которая заполнит спирально массив M на N.
/*
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
*/

