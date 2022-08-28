// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubedNumbers(int N)
{
    int count = 1;
    while (count <= N)
    {
        int i = Convert.ToInt32(Math.Pow(count,3));
        count++;
        Console.Write($"{i} ");
    }
}
Console.WriteLine("Vvedite naturalnoe chislo");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
   CubedNumbers(number);
}
else
{
    Console.WriteLine($"Vvedenoe chislo {number} ne naturalnoe");
}

