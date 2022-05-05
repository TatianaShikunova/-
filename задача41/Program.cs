// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* 0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите числа: ");
double [] ar = new double [m];
int count = 0;
for (int i=0; i< m; i++)
{
    ar[i] = double.Parse(Console.ReadLine());
    Console.WriteLine(String.Join(", " , ar));
}
foreach (double a in ar)
{
    count += a >3 ? 1 : 0;
}
Console.WriteLine($"{String.Join(", " , ar)} - > количество чисел больше 3: {count}");
