// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр
// //            в числе. 452 -> 11  82 -> 10  9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0; 
int b=0;
while (a>0)
{
    b=a%10;
    sum=sum+b; 
    a=a/10;  
}
Console.WriteLine( $"Сумма цифр в числе: {sum}");
