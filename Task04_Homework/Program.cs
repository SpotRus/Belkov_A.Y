// Напишите программу, которая: 
// 1. Принимает на вход три числа. 
// 2. Выдаёт максимальное из этих чисел.

// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;


if (maxNumber < secondNumber) maxNumber = secondNumber;
if (maxNumber < thirdNumber) maxNumber = thirdNumber;

Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} -> {maxNumber}");