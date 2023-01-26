/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

// ввод данных
Console.WriteLine("input to numbers");
Console.Write("the first is: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("and the second is: ");
int b = Convert.ToInt32(Console.ReadLine());
// сравнение и вывод

if (a>b) 
Console.WriteLine($"max = {a}, min = {b}");
else
if (a==b)
Console.WriteLine($"max = min, {a} = {b}");
else
Console.WriteLine($"max = {b}, min = {a}");
