﻿// Напишите программу, которая: 
// 1. На вход принимает число 
// 2. Выдаёт его квадрат (число умноженное на само себя).
// 3. Выводит результат.

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
// Console.WriteLine(number + " -> " + square);
Console.WriteLine($"{number} -> {square}");