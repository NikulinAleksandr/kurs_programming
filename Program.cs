//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    /*
        int num1, num2;    
        Console.WriteLine("Введите два числа: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine("{0} наибольшее число", num1);
            Console.WriteLine("{0} наименьшее число", num2);
        }
        else
        {
            Console.WriteLine("{0} наибольшее число", num2);
            Console.WriteLine("{0} наименьшее число", num1);
        }
        Console.ReadLine();
*/
      

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.				
/*			
int num1, num2, num3;				
Console.WriteLine("Введите три числа: ");				
num1 = Convert.ToInt32(Console.ReadLine());				
num2 = Convert.ToInt32(Console.ReadLine());				
num3 = Convert.ToInt32(Console.ReadLine());				
int max = num1;				
if (num2 > max);				
    max = num2;				
if (num3 > max);				
    max = num3;				
Console.WriteLine("{0} максимальное число", max);				
*/	

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int num;
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine()); 
if (num % 2 != 0)
    Console.WriteLine("{0} число не четное", num);
else 
    Console.WriteLine("{0} число четное", num);
Console.ReadLine();
*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
int num;
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < num)
{
    Console.WriteLine(i + 1);
    i += 2;
}
*/