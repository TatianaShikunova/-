// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using System;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;

Console.WriteLine($"max = {max}");
