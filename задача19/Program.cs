﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* 14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число");


// string "ч и с л о""
//         0 1 2 3 4

string num = Console.ReadLine();
string answer = (num[0] == num [4]&&num[1] == num [3])?$"да":"нет";

Console.WriteLine(answer);