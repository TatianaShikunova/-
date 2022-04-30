// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива, и программа покажет количество чётных чисел в массиве: ");

int [] array = GetArray(int.Parse(Console.ReadLine()));
Console.Write($"[{String.Join(", ", array)}] -> ");
Console.WriteLine(EvenArray(array));

int[] GetArray (int length)
{
    int [] array = new int[length]; 
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(100,1000);
    }
    return array;
}

int EvenArray (int [] arr)
{
    int count  = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 ==0)
        count++;
    }
    return count;
}
