// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdDigit(int number)
{
    int num=number;
    int count = 0;
    while (num/10 != 0)
    {
        count ++;
        num = num/10;
    }
    if (count >= 2)
    {
        int n = count-2;
        while ( n > 0)
        {
            number = number/10;
            n = n-1; 
        }
        int digit = number%10;
        Console.WriteLine($"Third digit is {digit}");
    }
    else
    {
        Console.WriteLine("No Third Digit");
    }

}
Console.Write("Imput integer number ");
int Number = Convert.ToInt32(Console.ReadLine());
ThirdDigit(Number);
