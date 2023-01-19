

Console.Clear();
Console.Write("Введите 1-ое число: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int e = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int f = Convert.ToInt32(Console.ReadLine()), max = d;
if (e >= max && e >= f)
   Console.Write(e);
else 
   Console.Write(f);