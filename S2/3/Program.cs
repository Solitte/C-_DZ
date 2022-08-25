//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Proverka(int number)
{
if (number == 6 || number == 7)
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Not weekend");
}
}

Console.Write("Input number day week ");
int day = Convert.ToInt32(Console.ReadLine());
Proverka(day);
