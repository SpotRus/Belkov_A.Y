// Напишите программу, которая: 
// 1. Выводит третью цифру заданного числа. 
// 2. Или сообщает, что третьей цифры нет.

// Наприме:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.Write("Введите цисло: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    Console.WriteLine($"{number} -> {ThirdNumber(number)}");
}
else
    Console.WriteLine($"{number} -> Третьей цифры нет");