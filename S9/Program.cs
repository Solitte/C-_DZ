
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void SeriesNumbers(int m, int n)
{
    if(n > m) 
    {
        SeriesNumbers(m, n-1);
        Console.Write(n+" ");
    }
    if(m > n) 
    {
        SeriesNumbers(m, n+1);
        Console.Write(n+" ");
    }
    if(n==m) Console.Write(n+" ");
}
Console.WriteLine("Input numbers diapozon");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
SeriesNumbers(m, n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumers(int m, int n)
{
    if (n > m) return SumNumers(m, n-1)+n;

    if (n < m) return SumNumers(m, n+1)+n;
    
    return m;
}

Console.WriteLine("Input numbers diapozon");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumers(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.