// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first integer ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"{number1} max, {number2} min");
}
else
{
    Console.WriteLine($"{number2} max, {number1} min");
}