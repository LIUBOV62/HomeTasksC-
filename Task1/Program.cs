/*
Console.Clear();  
Console.WriteLine("Hello, World!");
*/
// ctrl + / 
// Console.Clear();
// int a = 1, b = 2;
// Console.WriteLine($"{a}, {b}");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Результат: {n * 3}");
// Результат: 15 

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n > m)
//     Console.WriteLine(n);
// else if (n < m)    
// if (n < m)
//     Console.WriteLine(m);
// else
//     Console.WriteLine("=");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {n * n}");

// Задача 1

// Console.Clear();
// Console.Write("Введите 1-ое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число");
// int m = Convert.ToInt32(Console.ReadLine());
// if (m * m == n)
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");

// Console.Clear();
// Console.Write("Введите день недели: ");
// int n = Convert.ToInt32(Console.ReadLine());
// && -и(логическое умножение
// || -или(логическое сложение)
// True - 1
// False - 0
//        1  +  0  = 1(True)
// while (n < 1 || n > 7)
//   {
//     Console.Write("Вы ошиблись!\nВведите день недели: ");
//     n = Convert.ToInt32(Console.ReadLine());
//   }
// if (n == 1)
//       Console.WriteLine("Понедельник");
// else if (n == 2)
//       Console.WriteLine("Вторник");
// else if (n == 3)
//       Console.WriteLine("Среда");   
// else if (n == 4)
//       Console.WriteLine("Четверг");
// else if (n == 5)
//       Console.WriteLine("Пятница");
// else if (n == 6)
//       Console.WriteLine("Суббота.Выходной ");
// else
//       Console.WriteLine("Воскресенье.Выходной ");


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = n * (-1);
// while (m <= n)
// {
//     Console.Write($"{m} ");
//     m = m + 1;      m++;     
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n % 10);

// Второй семинар

//  Домашнее задание семинара № 1

//  Задача  2: Напишите программу, которая на вход принимает
//   два числа,какое число большее, а какое  меньшее.
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if(n > m) 
//    Console.Write($" max {n},min {m} ");
// else if(n < m)
//    Console.Write($" max {m},min {n} ");
// else   
//    Console.Write("=");

// Задача 4:  Напишите программу, которая на вход принимает
//   три числа и выдаёт максимальное из этих чисел.
//  Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-е число: ");
// int c = Convert.ToInt32(Console.ReadLine()),max = a;
// if(max < b)
//    max = b;
// if(max < c)
//    max = c; 
// Console.Write(max);

// Второй способ
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int d = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-е число: ");
// int f = Convert.ToInt32(Console.ReadLine()),max = d;

// if(i >= max && i >= f)
//     Console.Write(i);
// else 
//     Console.Write(f);

// Задача 6:  Напишите программу, которая на вход принимает
//   число и выдаёт, является ли число чётным (делится ли оно на  два без остатка).

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int g = Convert.ToInt32(Console.ReadLine());
// if (g %2 == 0)
//     Console.Write("Чётное");
// else
//     Console.Write("Нечётное"); 

// Задача 8 Напишите программу, которая на вход принимает число (N),
//          а на выходе показывает все чётные числа от 1 до N. 

// Console.Clear();
// Console.Write("Введите число: ");
// int h = Convert.ToInt32(Console.ReadLine()), count = 2;
// while (count <= h)
// {
//       Console.Write($"{count} ");  
//       count = count + 2;
// }
// Второй способ 
// Console.Clear();
// Console.Write("Введите число: ");
// int j = Convert.ToInt32(Console.ReadLine());
// for(int i = 2; i <= j; i += 2 )    // begin, condition, step
// Console.Write($"{i}");


// СЕМИНАР 2

// Задача: Напишите программу, которая выводит случайное число из отрезка [10, 99]
        // и показывает наибольшую цифру числа.
// Console.Clear();
// int p =new Random().Next(10, 100);    
// // тогда будут включены[10, 99] 
// Console.WriteLine($"Случайное число: {p}");
// int p1 = p / 10;
// int p2 = p % 10;
// if (p1 > p2)
// Console.WriteLine(p1);
// else
// Console.WriteLine(p2);

// ЗАДАЧА 11: Напишите программу, которая выводит случайное трёхзначное число 
          //  и удаляет вторую цифру этого числа.(456 -> 46  782 ->72  918 -> 98)

// Console.Clear();
// int t = new Random().Next(100, 1000);    
// // тогда будут включены[100, 999] 
// Console.WriteLine($"Случайное число: {t}");
// int t1 = t / 100;
// int t3 = t % 10;

// Console.WriteLine(t1 * 10 + t3);

// ЗАДАЧА 12: Напишите программу, которая будет принимать на вход 
//            два числа и выводить, является ли второе число кратным первому.
//            Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int s = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите 2-ое число: ");
// int k = Convert.ToInt32(Console.ReadLine());
// if (s % k == 0)
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine($"No, {s % k}");

// Задача  14: Напишите программу, которая на вход принимает число и проверяет,
//             кратно ли оно одновременно 7 и 23.

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 && a % 23 == 0)
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");

// Второй способ (Вводим наименьшее общее кратное для 7 и 23 т.е. 161)
// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 161 == 0 )
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");

// ЗАДАЧА 16: Напишите программу, которая на вход принимает два числа 
//            и проверяет , является ли одно число квадратом другого.
// Console.Clear();
// Console.Write("Введите 1-ое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n * n == m || m * m == n)
//     Console.WriteLine("Yes");

//     Console.WriteLine("No");

// СЕМИНАР №3 
// Домашняя работа
// ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа
        //    или сообщает, что третьей цифры  нет.
// Console.Clear();
// Console.Write("Введите 1-ое число");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 100)
// Console.WriteLine("Третьей цифры нет ");
// else
// {
//         while (n >= 1000)
//         {
//                 n = n / 10;
//         }
//         Console.WriteLine(n);
//         Console.WriteLine(n % 10);
// }

// ЗАДАЧА Напишите программу, которая на вход принимает последовательность 
//        натуральных чисел, завершающихся числом 0, а выдаёт второе
        // максимальное число в этой последовательности. 
//  Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()),max1 = n, max2 = 0; 
// while (n != 0)

// {
//        Console.Write("Введите число: ");
//        n = Convert.ToInt32(Console.ReadLine());
//        if (n > max1)
//        {
//            max2 = max1;
//            max1 = n;
//        } 
//        else if (n > max2)
//                 max2 = n;
// }
// Console.Write("Второй максимум: ");
// Console.WriteLine(max2);

// ЗАДАЧА 17:Напишите программу, которая пирнимает на вход координаты ( Х и У), 
//           причём Х != 0 и Y != 0 выдаёт номер четверти плоскости,
        //   в которой находится эта точка.
// Console.Clear();
// Console.Write("Введите координату  X: ");
// double X = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату  Y: ");
// double Y = Convert.ToDouble(Console.ReadLine());
// while (X == 0 || Y == 0)
// {
//       Console.WriteLine("Вы ошиблись! Введите координаты заново: ");
//       Console.Write("Введите координату  X: ");
//       X = Convert.ToDouble(Console.ReadLine());
//       Console.Write("Введите координату  Y: ");
//       Y = Convert.ToDouble(Console.ReadLine());      
// }
// if (X > 0 && Y > 0)
//       Console.WriteLine("|");
// else if (X < 0 && Y > 0)
//       Console.WriteLine("||");
// else if (X < 0 && Y < 0)
//       Console.WriteLine("|||");
// else 
//       Console.WriteLine("|V");
//  Второй способ (без проверки  Х и У на 0)

//  Console.Clear();
// Console.Write("Введите координату  X: ");
// double X = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату  Y: ");
// double Y = Convert.ToDouble(Console.ReadLine());
// //if (X > 0 && Y > 0)
//       Console.WriteLine("|");
// else if (X < 0 && Y > 0)
//       Console.WriteLine("||");
// else if (X < 0 && Y < 0)
//       Console.WriteLine("|||");
// else 
//       Console.WriteLine("|V"); 

// Задача 18: Напишите программу, которая по заданному номеру четверти,
//            показывает дапазон возможных координат точек вэтой четверти(Х и У).∞
// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
// {
// Console.WriteLine("Вы ошиблись!\nВведите число: ");
// n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
// Console.WriteLine("x(0, +∞) and y(0, +∞)");
// else if (n == 2)
// Console.WriteLine("x -∞, 0 and y 0, +∞ ");
// else if (n == 3)
// Console.WriteLine("x -∞, 0 and y -∞, 0 ");
// else
// Console.WriteLine("x(0, +∞) and y(-∞, 0)");

 
// ЗАДАЧА 21:Напишите программу, которая принимает на вход координаты двух точек и 
//           находит расстояние между ними в 2D пространстве.
// Console.Clear();
// Console.Write("Введите X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
// Console.WriteLine(l);

// ЗАДАЧА 22: Наапишите программу, которая на вход принимает число (N)
//            и выдаёт таблицу квадратов чисел от 1 до N.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// Console.Write($"{Math.Pow(i, 2)} ");

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
//           является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//        Console.WriteLine("Палиндром");
// else      
//        Console.WriteLine("НЕ палиндром");


//  Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//             и находит расстояние между ними в 3D пространстве.
//             A (3,6,8); B (2,1,-7), -> 15.84     A (7,-5, 0); B (1,-1,9) -> 11.53
//  Console.Clear();
// Console.Write("Введите X1: ");
// double X1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double Y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Z1: ");
// double Z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");
// double X2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double Y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Z2: ");
// double Z2 = Convert.ToDouble(Console.ReadLine());
// double l = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);
// Console.WriteLine(l); 

// Задача 23 Напишите программу, которая принимает на вход число (N) и 
//           выдаёт таблицу кубов чисел от 1 до N.
//           3 -> 1, 8, 27
//           5 -> 1, 8, 27, 64, 125

//  Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// Console.Write($"{Math.Pow(i, 3)} ");
//  Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
 
// int maxSumma = 0;
// for (int i = 1; i < array.Length - 1; i++)
// {
//     int sum = array[i - 1] + array[i] + array[i + 1];
//     if (sum > maxSumma)
//         maxSumma = sum;
// }
// if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
//     maxSumma = array[0] + array[1] + array[array.Length - 1];
 
// if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
//     maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];
 
// Console.WriteLine(maxSumma);

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10, 10]

// Console.WriteLine($"Результат: [{string.Join("    ", array)}]");
// фукция void
// фукция voidif(ref int n)
// {
//     n = n + 5;
// }

// int n = 10;
// f(ref n);
// Console.WriteLine(n);
// void f(ref int n)
// {
//     n = n + 5;
// }

// int n = 10;
// f(ref n);
// Console.WriteLine(n);

// Напишите программу, которая принимает 2 числа и выводит наибольшее число.
// int f(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }


// int a = 10, b = 7;
// Console.WriteLine(f(a, b));

// Task 24


Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {(1 + n) / 2 * n}");