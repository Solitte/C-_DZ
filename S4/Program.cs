/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int MyPow(int a, int b)
{
    int pow =1;
    for (int i = 1; i <= b; i++)
    {
        pow = pow*a;
    }
    return pow;
}
Console.Write("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
int pow = MyPow(number1,number2);
Console.WriteLine($"The first number {number1} to the power of the second number {number2} is {pow}.");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigits(int number)
{
    int sum = 0;
    int digit;
    while (number > 0)
    {
        digit = number%10;
        sum = sum + digit;
        number = number/10;
    }
    return sum;
}

Console.Write("Input integer number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Sum digits of number {number} is {SumDigits(number)}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] InputArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine($"Input integer {size} elements of array: ");
    Console.WriteLine();
    for (int i = 0; i<size; i++)
    {
        Console.Write(i+" - element array - ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();    
}

Console.Write("Input size array ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(size);
PrintArray(array);