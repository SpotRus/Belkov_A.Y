// Напишите программу, которая: 
// 1. Выводит случайноетрёхзначное число 
// 2. Удаляет вторую цифру этого числа.

// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100; // 4.56 = 4
    int thrdDigit = num % 10; // 45.6 = 6
    return firstDigit * 10 + thrdDigit; // 4 * 10 + 6 + 46
}

int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное трехзначное число: " + number);

int result = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {result}");