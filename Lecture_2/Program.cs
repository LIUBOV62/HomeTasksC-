// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.Clear();
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311321;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23111;
// int c3 = 313;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// //  int max = Max(max1, max2, max3);
// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);

// Console.Clear();
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
//  int[]array = {13, 2, 23, 41, 15, 6, 27, 8, 19};
//  int max = Max(
//      Max(array[0], array[1], array[2]),
//      Max(array[3], array[4], array[5]),
//      Max(array[6], array[7], array[8]));
//      Console.WriteLine(max);

Console.Clear();
int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18 };
int n = array.Length;
int find = 17;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //  index = index + 1;
    index++;
        
}