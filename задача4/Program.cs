// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using System;

Console.WriteLine($"введите а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"введите b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"введите c");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"{max}");
