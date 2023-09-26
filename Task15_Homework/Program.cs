// Напишите программу, которая: 
// 1. Принимает на вход цифру, обозначающую день недели.
// 2. Проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"{num} -> да");
        return true;
    }
    Console.WriteLine($"{num} -> нет");
    return false;
}

Console.Write("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <=7)
{
    Console.WriteLine(Weekend(number));
} 
else
    Console.WriteLine("Некоректный ввод.");