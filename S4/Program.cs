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
