// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first integer ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)    
{
    max = number3;
}
Console.WriteLine($"max - {max}");