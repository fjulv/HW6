// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToDouble(Console.ReadLine());
}

bool IntPoint (double k1, double b1, double k2, double b2)
{
    if (k1 != k2)
    {
        return true;
    }
    return false;
}

double k1 = Prompt("Введи значение k1 ");
double b1 = Prompt("Введи значение b1 ");
double k2 = Prompt("Введи значение k2 ");
double b2 = Prompt("Введи значение b2 ");
double x = ((b2 - b1) / (k1 - k2));
double y = k1 * x + b1;

if (IntPoint(k1, b1, k2, b2))
{
    System.Console.WriteLine($"Пересечение двух прямых находится в точке ({x} , {y})");
}
else
{
    System.Console.WriteLine($"Эти прямые не пересекаются");
}