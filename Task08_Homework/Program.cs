//  Напишите программу, которая: 
// 1. Принимает число (N). 
// 2. Показывает все чётные числа от 1 до N.

// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

Console.Write($"{number} -> ");

while (count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;  
}