// Заполните спирально массив 4 на 4.


Console.Clear();
int[,] array = new int[4, 4]; ;
PrintArray(array);
Console.WriteLine();
FillArray(2, 2);
PrintArray(array);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();

    }
}
void FillArray(int i, int j)
{
    while (i < 4)
    {
        while (j < 4)
            if (array[i, j] == 0)
            {
                array[i, j] = new Random().Next(1, 101);
                FillArray(i, j + 1);
                FillArray(i + 1, j);
                FillArray(i, j - 1);
                FillArray(i - 1, j);
            }
    }
}



