﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным 
//            и минимальным элементов массива.
//            [3.57, 7.96, 22.47, 2.12, 78.73] -> 76.61
void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); 

}


string DiffMaxAndMin(double[] array)
{
double minArray = array[0], maxArray = array[0];
foreach (double element in array)
{
if (element > maxArray)
maxArray = element;
if (element < minArray)
minArray = element;
}
return $"{maxArray} - {minArray} = {maxArray - minArray}";
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {DiffMaxAndMin(array)}");
