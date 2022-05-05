// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*  
k*x + b1 = k2*x +b2
k1*x - k2*x = b2 - b1
x = (b2 - b1)/(k1 - k2)
y = k1*(b2 - b1)/(k1 - k2) + b1
*/

Console.WriteLine("Найдите точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1*(b2 - b1)/(k1 - k2) + b1;
Console.WriteLine($"Координаты точки пересечения двух прямых: x = {x}, y = {y}");

