// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Введите B1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите K1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B2: ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите K2: ");
double k2 = int.Parse(Console.ReadLine());

double x = GetPointX(b1, k1, b2, k2);
if (k1 != k2)
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({GetPointX(b1, k1, b2, k2)}, {GetPointY(b1, k1, b2, k2)})");
else Console.WriteLine("Линии параллельны");

double GetPointX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double GetPointY(double b1, double k1, double b2, double k2)
{
    double y = k1 * x + b1;
    return y;
}
