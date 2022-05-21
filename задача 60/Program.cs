// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
Console.Write("Введите размеры трехмерного массива через пробел: ");
int [] size = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int a = size [0];
int b = size [1];
int c = size [2];
  
Console.WriteLine();
int[, ,] array = GetArray(a, b, c);
PrintArray(array);
Console.WriteLine();


int[, ,] GetArray(int rows, int columns, int depth)
{
    int[, ,] result = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                result[i, j, k] = new Random().Next(0, 1001);
            
            }
            
        }
    }
    return result;
}

void PrintArray(int[, ,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            
            for (int k = 0; k < ar.GetLength(2); k++)
            {
                Console.Write($"{ar[i, j,k]} ({i},{j},{k}) ");
            }
            
        }
        Console.WriteLine();
    }
}
