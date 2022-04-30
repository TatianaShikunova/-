/* // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */
using System;
using System.Linq;

Console.Write("Введите количество элементов массива, и программа покажет сумму элементов на нечетных позициях: ");
int [] array = new int [int.Parse(Console.ReadLine())].Select(x => new Random().Next(-1000, 1001)).ToArray();
Console.Write($"[{String.Join(", ", array)}] - > ");

Console.WriteLine(PosArray(array));

int PosArray (int [] arr)
{
    int sum = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        sum += i%2 > 0? arr[i] : 0;  
    }
    return sum;
}


