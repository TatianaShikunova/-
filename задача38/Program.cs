// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива: ");
int [] array = GetArray(int.Parse(Console.ReadLine()));
Console.Write($"[{String.Join(" ", array)}] -> ");
Console.WriteLine(SubtrArray(array));

int [] GetArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i< size; i++)
    {
        arr[i] = new Random().Next(-10000,10001);
    }
    return arr;
}

int SubtrArray (int [] ar)
{
    int max = ar [0];
    int min = ar [1];
    int subrt = 0;
   
    foreach (int a in ar)
    {
        if (a>max) 
        max = a;
        if (a<min) 
        min = a;
    }
    subrt = max - min;
    return subrt;
}
