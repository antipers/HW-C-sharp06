// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем

System.Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());

Checking(b1, k1, b2, k2);
void Checking(double b1, double k1, double b2, double k2)
{
    if (k1 - k2 == 0)
    {
        Console.WriteLine("Заданные прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Найдено пересечение в точке: ({x};{y})");
    }
}