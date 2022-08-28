// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double S(double x1, double y1, double z1, double x2, double y2, double z2)
{
   double s = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
   return s; 
}
Console.WriteLine("Vedite koordinaty pervoy tochki");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Vedite koordinaty vtoroy tochki");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double rasstoyanie = S(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Rasstoyanie mejdu tochkami = " + rasstoyanie);
