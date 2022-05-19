//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
Console.Clear();
Console.Write("задайте количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("задайте количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
ArifmArray(array);

int[,] GetArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(0, 1001);
        }
    }
    return result;
}

void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArifmArray(int[,] arr)
{
    Console.WriteLine("среднее арифметическое каждого столбца массива:");
    int j = 0;
    while (j < arr.GetLength(1))
    {
        double arifm = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arifm += arr[i,j];   
        }
        Console.WriteLine($"{arifm/arr.GetLength(0):f2}");
        j++;
        
    }
   
}
