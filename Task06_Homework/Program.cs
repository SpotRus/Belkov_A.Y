// Напишите программу, которая: 
// 1. Принимает число. 
// 2. Выдаёт является ли число чётным (делится ли оно на два без остатка).

// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine(number + " -> да четное");
}
else 
    Console.WriteLine(number + " -> нет нечетное");