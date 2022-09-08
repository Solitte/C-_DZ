// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
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
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] TochkaX(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    double[] tochka = {x,y};
    return tochka;
}
Console.WriteLine("Input k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2");
int b2 = Convert.ToInt32(Console.ReadLine());
if (k1==k2) Console.WriteLine("Pryamie paralelni");
else 
{
    double[] a = TochkaX(k1, b1, k2, b2);
    Console.WriteLine($"Tochka peresecheniya dvuh pryamih ({a[0]};{a[1]})");
}
