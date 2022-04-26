// Напишите программу, которая задаёт массив из n элементов и выводит их на экран.


Console.Write("Напишите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", Array(n))}]");

int [] Array (int num)
{
    int [] arr = new int [num];
    for (int i=0; i < num; i++)
    {
        arr [i] = new Random().Next(1, 100);
    }
    return arr;
}
