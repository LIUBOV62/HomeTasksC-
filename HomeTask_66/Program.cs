// See https://aka.ms/new-console-template for more information
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//             натуральных элементов в промежутке от M до N.
//             M = 1; N = 15 -> 120
//             M = 4; N = 8 -> 30
int sum(int n, int m)
{
    if (m == n)
       return m;
    return sum(m, n-1) + n; 
}
Console.Clear();
Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(S"Сумма элементов от{n}до{m}:{sum (m , n)} ");