//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"функция Аккермана А({m},{n})={Akk(m,n)}");

int Akk (int a, int b)
{
    if (a == 0) return b+1;
    else 
    {
        if ((a != 0) && (b == 0)) return Akk(a-1,1);
        return Akk(a-1, Akk(a, b-1));
    }
}
