// Задача 19 Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.

int Razryad(int number)
{
    int n = 0;
    while (number > 0)
    {
        number = number/10;
        n++;
    }
    return n;
}

bool Palindrom(int number)
{
    int N = Razryad(number);
    while (N>0)
    {
       int dig1 = number%10;
       int dig2 = number/Convert.ToInt32(Math.Pow(10,N-1));
       if (dig1 == dig2)
       {
        number = number%Convert.ToInt32(Math.Pow(10,N-1))/10;
        N = N-2;
       }
       else 
       {
        return false;
       }          
    }
    return true;
}

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>9)
{
 bool result = Palindrom(number);
 if (result == true) Console.WriteLine("Input number is palindrom");
 else Console.WriteLine("Input number is not palindrom");
}
else
{
 Console.WriteLine("Number entered is incorrect, input number > 9"); 
}
