// 1. Задайте значения M и N.
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 3. Выполнить с помощью рекурсии.

// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetInputUser(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumOfNumbers(int numM, int numN)
{
    if (numM > numN) return numM + SumOfNumbers(numM - 1, numN);
    else if (numM < numN) return numM + SumOfNumbers(numM + 1, numN);
    else return numM;
}

int userNumberM = GetInputUser("Найти сумму натуральных элементов в промежутке от числа: ");
Console.WriteLine();

int userNumberN = GetInputUser("до числа: ");
Console.WriteLine();

if (userNumberM < 0 || userNumberN < 0) Console.WriteLine("Некорректный ввод.");
else Console.WriteLine($"M = {userNumberM}; N = {userNumberN} -> {SumOfNumbers(userNumberM, userNumberN)}");