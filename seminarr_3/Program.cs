// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите число: ");
string text = Console.ReadLine();
int a = text.Length;
bool x = true;
for (int i = 0; i < a/2; i++)
  {
    if (text [i] != text [a - (i + 1)])
    {
        x = false;
        break;
    }
  }
    if (x)
    {
        Console.WriteLine("{0} это палиндромом", text);
    }
    else
    {
        Console.WriteLine("{0} это не палиндромом", text);
    }
  */


//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите координаты x, y, z первой точки: ");	
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x, y, z второй точки: ");	
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
double dist (int x1, int y1, int z1, int x2, int y2, int z2)
{

    double res = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return res;
}
double otvet = dist(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {otvet}");
*/
