// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double [,] array = GetArray(m,n);
for (int k = 0; k < m; k++)
{
    for (int l = 0; l< n; l++)
    {
        Console.Write($"{array[k,l]} ");
    }
    Console.WriteLine();
}

double [,] GetArray(int rows, int columns)
{
    double [,] result = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
            result [i,j] = new Random().Next(-10,10);
        }
    }
    return result;
}
