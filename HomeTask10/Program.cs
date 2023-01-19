// ЗАДАЧА 10 Написать программу, которая при вводе трёхзначного числа,
//           на выходе показывает вторую цифру этого числа.

 Console.Clear();
 Console.Write("Введите трёхзначное число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 int a1 = a / 10;
 int a2 = a1 % 10; 
    Console.WriteLine($"{a2}");       