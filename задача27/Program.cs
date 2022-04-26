// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Ведите любое число: ");

Console.WriteLine($"Сумма цифр в числе: {Summa(int.Parse(Console.ReadLine()))}");

int Summa (int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a%10; 
        a = a/10;
    }
    return sum;
}