/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

// ввод данных
Console.WriteLine("input three numbers");
Console.Write("the first is: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("the second is: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("and the third is: ");
int c = Convert.ToInt32(Console.ReadLine());
// сравнение и вывод
int max = a;
if (b>a) max = b;
if (c>max) max=c;
Console.WriteLine($"max = {max}");