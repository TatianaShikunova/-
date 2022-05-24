//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.

Console.WriteLine("введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"натуральные числа по убыванию в промежутке от M до N - > {Numbers(m,n)}");

string Numbers (int start, int end)
{
    if (start == end) return end.ToString();
    else return  start + " " + Numbers(start -1, end);
}
