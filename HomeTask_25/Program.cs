// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

 Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
int temp =n;

for (int i = 1; i < m; i++)
    temp = n * temp;

Console.WriteLine($"{temp}");