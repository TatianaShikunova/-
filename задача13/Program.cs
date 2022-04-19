// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число");

int num = int.Parse(Console.ReadLine());

if (num>=100)
{
    string numS = num.ToString();
    int a3 = Convert.ToInt32(numS[2].ToString());
    Console.WriteLine($"{num} -> {a3}");
}
else
{
  Console.WriteLine("третьей цифры нет");  
}