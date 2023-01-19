// ЗАДАЧА 8: Напишите программу, которая на вход принимает
// //           число (N), а на выходе все чётные от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()),count = 2;
while (count <= n)
{
      Console.Write($"{count} ");
      count = count + 2;
}