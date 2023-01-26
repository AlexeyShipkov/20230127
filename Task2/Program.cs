Console.WriteLine("input to numbers");
Console.Write("the first is: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("and the second is: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
Console.WriteLine($"max = {a}, min = {b}");
else
Console.WriteLine($"max = {b}, min = {a}");