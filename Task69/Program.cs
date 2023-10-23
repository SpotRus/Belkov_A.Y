// Напишите программу, которая:
// 1. Принимает два числа A и B.
// 2. Возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

double Exponentiation(double a, double b)
{
    if (b == 0) return 1;
    else if (b > 0) return a * Exponentiation(a, b - 1);
    else return 1 / (a * Exponentiation(a, -b - 1));
}

double GetInputUser(string msg)
{
    Console.Write(msg);
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double userNumberA = GetInputUser("Введите число A: ");
double userNumberB = GetInputUser("Введите число B: ");
Console.WriteLine($"A = {userNumberA}; B = {userNumberB} -> {Exponentiation(userNumberA, userNumberB)}");