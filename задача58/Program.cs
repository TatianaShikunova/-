// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк двумерых массивов: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов двумерых массивов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(rows, columns);
Console.WriteLine("массив №1");
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, columns);
Console.WriteLine("массив №2");
PrintArray(array2);
Console.WriteLine();
int[,] array3 = MultArray(array1, array2);
Console.WriteLine("массив - произведение массивов №1 и №2");
PrintArray(array3);
Console.WriteLine();

int[,] GetArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(1, 10);
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
int [,] MultArray (int [,] a, int [,] b)
{
    int[,] result = new int[a.GetLength(0), a.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            result[i, j] = a [i,j] * b [i,j];
        }
    }
    return result;

}