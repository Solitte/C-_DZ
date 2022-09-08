// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] InputArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine($"Input integer {size} elements of array: ");
    for (int i = 0; i<size; i++)
    {
        Console.Write($"{i} - ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int FindForArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = InputArray(size);
int count = FindForArray(arr);
Console.WriteLine($"Input of number > zero is {count}");