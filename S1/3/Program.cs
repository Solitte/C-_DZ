﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input integer ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    Console.WriteLine("even number");
}
else
{
    Console.WriteLine("odd number");
}