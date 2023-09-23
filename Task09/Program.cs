// Напишите программу: 
// 1. Которая выводит случайное число из отрезка [10, 99] 
// 2. Показывает наибольшую цифру числа.

// Наприме:
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);  // 99 + 1 = 100
Console.WriteLine($"Случайное число из отрезка от 10 до 99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // Тернарный оператор

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

