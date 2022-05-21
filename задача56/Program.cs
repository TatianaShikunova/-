// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

SumArray(array);

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

void SumArray(int[,] arr)
{
    int minsum = 0;
    int sum = 0;
    int number = 0;
    int i = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        minsum += arr[i,j];
    }

    for ( i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine(sum);
        if (sum < minsum)
        {
            minsum = sum;
            number = i + 1;
        }
        sum = 0;
    } 
    Console.WriteLine($"номер строки с минимальной суммой элементов: строка № {number}");
  
}