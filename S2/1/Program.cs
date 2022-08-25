//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int digit = (num%100)/10;
    return digit;
}

Console.Write("Imput integer number ");
int number = Convert.ToInt32(Console.ReadLine());
int secondigit = SecondDigit(number);
Console.WriteLine($"Second digit of {number} is {secondigit}");