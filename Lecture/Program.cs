﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.Clear();
// Console.WriteLine("Введите ваше имя: ");
// string username = Console.ReadLine();
// Console.WriteLine("Привет! ");
// Console.WriteLine(username);

//  Console.Clear();
//  int namberA = 31;
//  int namberB = 5;
//  int result = namberA + namberB;
//  Console.WriteLine(result);

//  Console.Clear();
//  double namberA = 12;
//  double namberB = 5;
//  Console.WriteLine(namberA / namberB);

//  Console.Clear();
//  int namberA = new Random().Next(1, 10);
//  Console.WriteLine(namberA);
//  int namberB = new Random().Next(1, 10);
//  Console.WriteLine(namberA);
//  int result = namberA + namberB;
//  Console.WriteLine(result);

// Console.Clear();
// Console.WriteLine("Введите имя пользователя:");
// string? lastname = Console.ReadLine();

// if(lastname.ToLower() == "маша")

//     Console.WriteLine("Ура, это же МАША!");

// else

//     Console.Write("Привет, ");
//     Console.WriteLine(lastname);



// Console.Clear();
// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if(a > max ) max = a;
// if(b > max ) max = b;
// if(c > max ) max = c;
// if(d > max ) max = d;
// if(e > max ) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);

 Console.Clear();
//  Console.SetCursorPosition(10, 4);
//  Console.WriteLine("*");

int xa = 30, ya = 4,
    xb = 1, yb =20,
    xc = 60, yc = 20;

 Console.SetCursorPosition(xa ,ya);
 Console.WriteLine("*");
 Console.SetCursorPosition(xb ,yb);
 Console.WriteLine("*");
 Console.SetCursorPosition(xc ,yc);
 Console.WriteLine("*");

 int x = xa, y = xb;

 int count = 0;

 while(count<1000)
 {
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1;
 }   