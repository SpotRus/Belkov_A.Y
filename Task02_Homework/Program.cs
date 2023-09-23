// Напишите программу, которая: 
// 1. Принимает два числа. 
// 2. Выдаёт какое число большее, а какое меньшее.

// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (firstNumber > secondNumber)
{
    Console.WriteLine($" a = {firstNumber}; b = {secondNumber} -> max = {firstNumber}");
}
else
    Console.WriteLine($" a = {firstNumber}; b = {secondNumber} -> max = {secondNumber}");