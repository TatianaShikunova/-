// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* 3 -> 1, 8, 27
   5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Ведите число N");

int n = int.Parse(Console.ReadLine());

Console.Write($"{n} - > ");

for (int i = 1; i <= n; i++)
{
    double result = Math.Pow(i,3);
    Console.Write ($"{result} ");
}
