Console.WriteLine("Hello, World!");
// ЗАДАЧА 6: Напишите программу, которая на вход принимает число и выдаёт,
//           является ли оно чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());  
if(a % 2 == 0)
   Console.Write("Чётное");
else 
   Console.Write("Нечётное");

