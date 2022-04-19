//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

using static System.Console;

WriteLine("Введите трехзначное число");

int number = int.Parse(ReadLine());

//int number1 = number%100;
//int number2 = number1/10;

//WriteLine(number2);

string numberS = number.ToString();
int a2 = Convert.ToInt32(numberS[1].ToString());
WriteLine($"{number} -> {a2}");

