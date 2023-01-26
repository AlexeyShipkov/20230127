/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

// ввод данных
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
// сравнение и вывод
int count = 2;
while(count<=a)
{
Console.Write($"{count}, ");    
count=count+2;
}
Console.WriteLine();    
Console.WriteLine($"Перечислены все четные числа, меньшие или равные {a}.");    
