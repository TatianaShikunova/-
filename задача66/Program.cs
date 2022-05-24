//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма натуральных элементов в промежутке между {m} и {n} -> {Sum(m,n)}");

int Sum (int a, int b)
{
    if (a == b) return b;
    return a + Sum (a+1, b); 
}
