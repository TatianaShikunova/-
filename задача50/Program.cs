// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

Console.WriteLine("Введите позиции элемента:");

Console.Write("строка: ");
int a = int.Parse(Console.ReadLine());
Console.Write("столбец: ");
int b = int.Parse(Console.ReadLine());

int[,] array = new int[10, 10];
FillArray(array);
PrintArray(array);
FindArray(array, a, b);


void FillArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = new Random().Next(1, 1001);
        }
    }
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

void FindArray(int[,] arr, int x, int y)
{
    if (x <= arr.GetLength(0) && y <=arr.GetLength(1))
    {
       for (int i = 0; i < arr.GetLength(0); i++)
       {
          for (int j = 0; j < arr.GetLength(1); j++)
          {
            if (i == x - 1 && j == y - 1) Console.WriteLine($"{arr[i, j]} ");  
          } 
       } 
    }
    else Console.WriteLine("числа с такой позицией в массиве нет");   
}
