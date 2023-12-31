﻿using System;

public class Answer
{
    static void ShowCube(int N)
    {
        // Введите свое решение ниже
        int count = 1;
        while (count <= N)
        {
            Console.WriteLine($"{count * count * count}");
            count++;
        }
    }
    // Решение
    // static void ShowCube(int N)
    // {
    //     for (int i = 1; i <= N; i++)
    //     {
    //         Console.WriteLine(Cube(i));
    //     }
    // }

    // public static int Cube(int number)
    // {
    //     return number * number * number;
    // }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 3;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}