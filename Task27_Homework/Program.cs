// Напишите программу, которая: 
// 1. Принимает на вход число.
// 2. Выдаёт сумму цифр в числе.

// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumDigits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

int number = GetUserInput("Введите число: ");

Console.WriteLine($"{number} -> {SumDigits(number)}");