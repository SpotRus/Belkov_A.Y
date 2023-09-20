// Напишите программу, которая: 
// 1. На вход принимает два числа
// 2. Проверяет, является ли первое число квадратом второго.
// 3. Выводит результат.

// Например:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое целое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (second_number * second_number == first_number)
{
    Console.WriteLine($"a = {first_number}, b = {second_number} -> да");
}
else
    Console.WriteLine($"a = {first_number}, b = {second_number} -> нет");