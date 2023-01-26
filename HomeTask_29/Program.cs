// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит
//            их на экран(ввод пользователя с клавиатуры).
//            1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
// int[] array = new int[8];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 50);
// Console.WriteLine($"Результат: [{string.Join(",", array)}]");


Console.Clear();
int[] array = new int[8];

for(int i = 0; i < array.Length; i++) 
{
       Console.Write($"Введите элемент массива под индексом {i}: ");
       array[i] = Convert.ToInt32(Console.ReadLine());
}
       Console.WriteLine($"Результат: [{string.Join(",", array)}]");