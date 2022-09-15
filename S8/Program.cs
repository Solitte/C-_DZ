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
*/

//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] Random2DArray()
{
    Console.WriteLine("Input the rows of the matrix");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the matrix");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the minimum number of the matrix");
    int minElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the maximum number of the matrix");
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

int[,] MultiMatrix(int [,] a, int[,] b)
{
    int[,] multi = new int[a.GetLength(0),b.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for(int r = 0; r < a.GetLength(1); r++) 
                sum = sum + a[i,r]*b[r,j];
    
            multi[i,j]= sum;
            sum=0;                 
        }
        return multi;
}

Console.WriteLine("For first matrix");
int[,] a = Random2DArray();
Console.WriteLine("For second matrix");
int[,] b = Random2DArray();
if (a.GetLength(1) != b.GetLength(0))
    Console.WriteLine("Columns in first matrix need to be equals rows in second matrix");
else
{
    Console.WriteLine("First matrix");
    Print2DArray(a);
    Console.WriteLine("Second matrix");
    Print2DArray(b);
    int[,] multi = MultiMatrix(a,b);
    Console.WriteLine("Multiplication matrix's first & second is");
    Print2DArray(multi);
}
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Array3D()
{
    Console.WriteLine("Input the rows of the matrix");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the matrix");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the layers of the matrix");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


    int[,,] matrix = new int[rows, columns, layers];
    int count = 10;
    for (int k = 0; k < layers; k++)
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                matrix[i,j,k] = count;
                count++;
            }
    return matrix;
}

void Print3DArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        Console.WriteLine($"Layer {k}");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i,j,k]} ");
                Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();   
}

int[,,] matrix = Array3D();
if (matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2) < 91) Print3DArray(matrix);
else Console.WriteLine("Rows * columns * layers need to be lower than 91");


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

