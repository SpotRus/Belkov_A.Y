// Напишите программу:
// 1. Принимает на вход число.
// 2. Возвращать сумму его цифр.

// Например:
// 453 -> 12
// 45 -> 9

int GetInputUser(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10);
}

int userInput = GetInputUser("Введите число: ");
Console.WriteLine($"{userInput} -> {SumOfDigits(userInput)}");//453 45 4