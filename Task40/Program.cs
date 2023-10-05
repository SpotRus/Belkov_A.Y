﻿// 1. Напишите программу, которая принимает на вход три числа.
// 2. Проверяет, может ли существовать треугольник с сторонами такой длины.

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}

int sideA = GetUserInput("Введите сторону А: ");
int sideB = GetUserInput("Введите сторону B: ");
int sideC = GetUserInput("Введите сторону C: ");

bool result = IsExistTriangle(sideA, sideB, sideC);

Console.WriteLine(result ? "Треугольник существует." : "Треугольник не существует.");

