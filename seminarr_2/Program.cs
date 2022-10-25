

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int num;
Console.WriteLine("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
num = num/10;
int i = num%10;
Console.WriteLine($"Вторая цифра числа равна {i}");
*/




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int num;
Console.WriteLine("Введите  число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num/100 > 0)
{
    string str = num.ToString();
    Console.WriteLine($"Третья цифра заданого числа равна: {str[2]}");
}
else
    Console.WriteLine("Третьей цифры нет! ");
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int num;
Console.WriteLine("Введите  число от 1 до 7: ");
num = Convert.ToInt32(Console.ReadLine());
if (num == 6 | num == 7)
    Console.WriteLine("Да!, сегодня выходной день");
else
    Console.WriteLine("Нет!, сегодня рабочий день");
*/

