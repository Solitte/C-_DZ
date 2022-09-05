// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] RandomArray(int size, int minElem, int maxElem)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minElem, maxElem+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

int CounterEvenNumber(int[] arr)
{
    int count = 0;
    for (int i =0; i < arr.Length; i++)
    {
       if (arr[i]%2 == 0) count ++;
    }
    return count;
}

int min = 100;
int max = 999;
Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
Console.WriteLine();
int result = CounterEvenNumber(array);
Console.WriteLine($"Even numbers of array is {result}");

*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] RandomArray(int size, int minElem, int maxElem)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minElem, maxElem+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

int SumElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum number of the array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum number of the array");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
Console.WriteLine();
int result = SumElementsArray(array);
Console.WriteLine($"Sum of elements in odd positions: {result}");
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] RandomArray(int size, int n)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*n,2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

double DifferenceMaxMin (double[] array)
{
    double max = 0;
    double min = 0;
    if (array[0] < array[1])
    {
        min = array[0];
        max = array[1];
    }
    else
    {
       min = array[1];
       max =array[0]; 
    }
   for (int i = 0; i < array.Length; i++)
   {
    if (max < array[i]) max = array[i];
    else if (min > array[i]) min = array[i];
   }
   double result  = max - min;
   return result;
}

Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum value");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = RandomArray(size, n);
PrintArray(array);
Console.WriteLine();
double dif = DifferenceMaxMin (array);
Console.WriteLine($"Difference between the maximum and minimum element of the array: {dif}");