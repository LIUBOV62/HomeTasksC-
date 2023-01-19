
// ЗАДАЧА 2: Напишите программу, которая на вход принимает два
//           числа и выдаёт, какое число большее, а какое меньшее . 

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n > m)
    Console. Write($" max {n}, min {m} ");
else if(n < m)
    Console. Write($" max {m}, min {n} ");
else
Console. Write(" = ");