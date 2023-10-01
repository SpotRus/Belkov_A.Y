// Напишите цикл, который: 1. Принимает на вход два числа (A и B).
// 2. Возводит число A в натуральную степень B.

// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ErectDegree(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

int UserInput(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num; 
}

int numberA = UserInput("Введите число: ");
int numberB = UserInput("Введите степень: ");

int res = ErectDegree(numberA, numberB);

Console.WriteLine($"{numberA}, {numberB} -> {res}");