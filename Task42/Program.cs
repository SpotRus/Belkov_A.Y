﻿// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// Например:
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int GetUserInput(string msg)
{
    Console.Write($"{msg}");
    int quarter = Convert.ToInt32(Console.ReadLine());
    return quarter;
}

// string DecimalToBinary(int number, int baseNum)
// {
//     string result = String.Empty;

//     while (number > 0)
//     {
//         result = number % baseNum + result;
//         number /= baseNum;
//     }
//     return result;
// }

int DecimalToBinaryInt(int number, int baseNum)
{
    int result = 0;
    int mult = 1;

    while (number > 0)
    {
        result = (number % baseNum) * mult + result;
        mult *= 10;
        number /= baseNum;
    }
    return result;
}

int num = GetUserInput("Введите исходное число: ");
int baeNumber = GetUserInput("Перевести в: ");
int binNum = DecimalToBinaryInt(num, baeNumber);
Console.WriteLine($"{num} -> {binNum}");