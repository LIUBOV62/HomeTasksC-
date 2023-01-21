
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()),max1 = n, max2 = 0; 
while (n != 0)

{
       Console.Write("Введите число: ");
       n = Convert.ToInt32(Console.ReadLine());
       if (n > max1)
       {
           max2 = max1;
           max1 = n;
       } 
       else if (n > max2)
                max2 = n;
}
Console.Write("Второй максимум: ");
Console.WriteLine(max2);
