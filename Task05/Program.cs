// Напишите программу, которая: 
// 1. На вход принимаетодно число (N). 
// 2. На выходе показывает все целые числа в промежутке от -N до N.

// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = -number;

if (number > 0)
{
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
    }
}
else
    Console.WriteLine("Некорректное число.");
