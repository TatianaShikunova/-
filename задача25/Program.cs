// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{a}, {b} -> {Exponentiation(a, b)}");

//a^5 = a*a*a*a*a = 1*a*a*a*a*a

int Exponentiation (int number1, int number2)
{
    int e = 1;
    for (int i=1; i <= number2; i++)
    {
        e *= number1;
    }
    return e;
}
