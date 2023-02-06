// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
       Console.WriteLine(col[position]);
       position++;   
    }
}

int IndexOf(int[]collection, int find )
{
  int count = collection.Length;
  int index = 0;
  int position = -1;
  while(index < count)
  { 
    if(collection[index] == find) {
       position = index;
       break;
    }
    index++;
  } 
 
return position;
}
int[] array = new int[10];

int find = 5;

FillArray(array);
array[4] = find;
array[6] = find;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, find);
Console.WriteLine(pos);