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


// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {(1 + n) / 2 * n}");

// Task 26


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;
// while (n > 0)
// {
//     n = n / 10;
//     count++; // count = count + 1
// }
// Console.WriteLine(count);

// Task 28


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// for (int i = 2; i <= n; i++)
//     count = count * i;

// Console.WriteLine(count);
// Console.Clear();
// Console.Write("Введите число кустов: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] arr = {4, 3, 2, 1}; // Урожай с кустов

// int a[i] = [1, 2, 3, 4];
// int max = 0;
// int b = arr[arr.Length -1] + arr[0] + arr[1];
// int c = arr[arr.Length -2] + arr[arr.Length -1] + arr[0];

// if (b > c) 
//     max = b; 
// else 
//     max = c;

// for (int i = 0; i < arr.Length - 2; i++)
// {   
//     int a = arr[i] + arr[i + 1] + arr[i + 2];

//     if (a > max)
//     max = a;
// }

// Console.WriteLine($"Максимальное число ягод: {max} ");

// Задача : Максимальное количество ягод 
// Console.Clear();
// Console.Write("Введите колличество кустов черники: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n + 2];
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//      Console.Write("Число ягод черники на кусте: ");
//      a[i] = Convert.ToInt32(Console.ReadLine());
//      a[n] = a[0];
//      a[n + 1] = a[1];
// }
// for (int i = 1; i < n + 1; i++)
// {
//      int sum1 = a[i - 1] + a[i] + a[i + 1];
//      if (sum1 > sum)
//         sum = sum1;
// }
// Console.WriteLine($"Максимальное колличество ягод: {sum}");

// Домашняя работа № 4
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
        //    и возводит число A в натуральную степень B.
//            Math.Pow(ЗАПРЕЩЕНО) 3, 5 -> 243 (3⁵),  2, 4 -> 16
//  Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int temp =n;

// for (int i = 1; i < m; i++)
//     temp = n * temp;

// Console.WriteLine($"{temp}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр
//            в числе. 452 -> 11  82 -> 10  9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0; 
// int b=0;
// while (a>0)
// {
//     b=a%10;
//     sum=sum+b; 
//     a=a/10;  
// }
// Console.WriteLine( $"Сумма цифр в числе: {sum}");

// Эту задачу на семинаре так записали.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), result = 0;
// while (n > 0)
// {
//     result = result + n % 10; // result += n %  10;
//     n = n / 10; // n /= 10;
// }
// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//            и выводит их на экран(ввод пользователя с клавиатуры).
//            1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Console.Clear();
// int[] array = new int[8];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 50);
// Console.WriteLine($"Результат: [{string.Join(",", array)}]");
    

// Console.Clear();
// // Console.Write("Введите количество элементов массива: ");

// // int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[8];

// for(int i = 0; i < array.Length; i++) 
// {
//        Console.Write($"Введите элемент массива под индексом {i}: ");
//        array[i] = Convert.ToInt32(Console.ReadLine());
// }
//        Console.WriteLine($"Результат: [{string.Join(",", array)}]");

// СЕМИНАР 5

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
//            [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//            Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
//            равна 29, сумма отрицательных равна -20.
// task 31

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     int summaPositive = 0, summaNegative = 0;
//     foreach (int element in array)
//     {
//         if (element > 0)
//             summaPositive += element;
//         else
//             summaNegative += element;
//     }
//     Console.WriteLine($"Сумма положительных чисел равна: {summaPositive}");
//     Console.WriteLine($"Сумма отрицательных чисел равна: {summaNegative}");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);


// / task 31

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1); // array[i] = array[i] * (-1);
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// string ReleaseArray(int[] array, int number)
// {
//     foreach (int element in array)
//     {
//         if (element == number)
//             return "yes";
//     }
//     return "no";
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое Вы ищите внутри массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReleaseArray(array, number));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
//            элементов массива, значения которых лежат в отрезке [10,99]. 
//            Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//            [5, 18, 123, 6, 2] -> 1
//            [1, 2, 3, 6, 2] -> 0
//            [10, 11, 12, 13, 14] -> 5

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-9, 9]
// }


// int ReleaseArray(int[] array)
// {
//     int count = 0;
//     foreach (int element in array)
//     {
//         if (element >= 10 && element <= 99)
//             count++; // count = count + 1;
//     }
//     return count;
// }


// Console.Clear();
// // Console.Write("Введите кол-во элементов массива: ");
// // int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(ReleaseArray(array));

// Задача 37

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//         Console.Write($"{array[i] * array[array.Length - i - 1]} ");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);

// ЗАДАЧА: Задайте массив заполненный случайными положительными трёхзначными числами. 
//    Напишите программу, которая покажет количество чётных чисел в массиве

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.Write("Массив: ");
// ReleaseArray(array);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// if (array[i] %2 == 0)
//     count++;

// Console.WriteLine($"Всего {array.Length}, {count}  четные");

// void InputArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(100, 1000);
// }

// void ReleaseArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
//     Console.WriteLine();
// // }

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);

// // Задача 50:
// //  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// //  и возвращает значение этого элемента или же указание, что такого элемента нет
Console.Clear();
Console.Write("Введите позицию элемента строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];
InputMatrix(matrix);


if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
{
Console.WriteLine("Такого элемента нет: ");
}
else
{
Console.WriteLine($"Значение элемента{m}строкии {n} столбца равно {matrix[m - 1 , n - 1]}");

}
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


// Задача50
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите позицию элемента строки: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию элемента столбца: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[3, 4];
// InputMatrix(matrix);


// if (m > matrix.GetLength(0) && n > matrix.GetLength(1))
// {
//     Console.WriteLine("Элемент отсутствует");
// }
// else
// {
// Console.WriteLine($"Значение элемента с позицией({m}, {n})равно{matrix[m - 1, n - 1]}");
// }

//  ЗАДАЧА 50:
//  void InputMatrix(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2);
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }


// double SearchElementToMatrix(double[,] matrix, int row, int column)
// {
// if (matrix.GetLength(0) > row && matrix.GetLength(1) > column && row >= 0 && column >= 0)
// return matrix[row, column];
// return 0;
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);
// int[] coord = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// Console.Write("Введите позицию элемента: ");
// double result = SearchElementToMatrix(matrix, coord[0] - 1, coord[1] - 1);
// if (result != 0)
// Console.WriteLine(result);
// else
// Console.WriteLine("Такого числа нет");

