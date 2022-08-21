// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(count <= N)
{
    while(count <= N)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
else 
{ 
    count = 0;
    while (count >= N)
    {
       Console.Write($"{count} ");
       count = count - 2;
    }
}