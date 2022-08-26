// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdDigit(int number, int numberdigit)
{
    int num=number;
    int count = 1;    
    while (num/10 != 0)
    {
        count ++;
        num = num/10;
    }

    if (count >= numberdigit)
    {
        int n = count-numberdigit;
        while ( n > 0)
        {
            number = number/10;
            n = n-1; 
        }
        int digit = number%10;
        Console.WriteLine($"NumberDigit is {digit}");
    }
    else
    {
        Console.WriteLine("No NumberDigit");
    }

}
Console.Write($"Input integer number ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input NumberDigit ");
int numberdigit = Convert.ToInt32(Console.ReadLine());
ThirdDigit(Number,numberdigit);
