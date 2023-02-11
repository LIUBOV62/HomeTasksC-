// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//             Даны два неотрицательных числа m и n.
//             m = 2, n = 3 -> A(m,n) = 9     m = 3, n = 2 -> A(m,n) = 29
            //              n+1                m = 0
            //  A(m,n) + {  A(m-1,1)           m > 0, n = 0
            //              A(m-1,A(m,n-1))    m > 0, n > 0
int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    
    if(n == 0 && m > 0)
          return Ackerman(m - 1, 1);
    
    if(m > 0, n > 0)
          return Ackerman(m - 1, Ackerman(m, n - 1));

}
Console.Clear();
Console.Write("Введите 1-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 1-е число: ");
int n  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ackerman(m, n)");