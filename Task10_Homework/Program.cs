// Напишите программу, которая: 
// 1. Принимает на вход трёхзначное число. 
// 2. Показывает вторую цифру этого числа.

// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int num)
{
    int firstDigit = num / 100;
    int secondNumber = num / 10;
    return secondNumber - firstDigit * 10;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= -999 && number <= 999)
{
    Console.WriteLine($"{number} -> {SecondNumber(number)}");
}
else
    Console.WriteLine("Некоректный ввод.");