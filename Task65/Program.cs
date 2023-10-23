// 1. Задайте значения M и N.
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetInputUser(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void CounterFrom(int numM, int numN)
{
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        CounterFrom(numM - 1, numN);
    }
    else if (numM < numN)
    {
        Console.Write($"{numM} ");
        CounterFrom(numM + 1, numN);
    }
    else Console.Write(numM);
}

int userNumberM = GetInputUser("Введите число M: ");
int userNumberN = GetInputUser("Введите число N: ");
Console.Write($"M = {userNumberM}; N = {userNumberN} -> ");
CounterFrom(userNumberM, userNumberN);