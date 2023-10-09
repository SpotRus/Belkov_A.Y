// Напишите программу, которая:
// 1. Найдёт точку пересечения двух прямых. 
// 2. Заданная уравнением y = k1 * x + b1, y = k2 * x + b2;
// 3. Значения b1, k1, b2 и k2 задаются пользователем.
// 
// Например:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetUserInput(string msg)
{
    Console.Write(msg);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double pointY;
    double pointX;
    pointX = -(b1 - b2) / (k1 - k2);
    pointY = k1 * pointX + b1;
    return new double[] { pointX, pointY };
}

double numberK1 = GetUserInput("Введите координату k1: ");
double numberB1 = GetUserInput("Введите координату b1: ");
double numberK2 = GetUserInput("Введите координату k2: ");
double numberB2 = GetUserInput("Введите координату b2: ");
double[] result = IntersectionPoint(numberK1, numberB1, numberK2, numberB2);

Console.WriteLine($"k1 {numberK1}, b1 {numberB1}, k2 {numberK2}, b2 {numberB2} -> ({Math.Round(result[0], 3)}; {Math.Round(result[1], 3)})");