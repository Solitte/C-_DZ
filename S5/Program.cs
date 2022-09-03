// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
Console.WriteLine("Vvedite razmer massiva");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
Console.WriteLine();
int result = CounterEvenNumber(array);
Console.WriteLine($"Even numbers of array is {result}");
