// Напишите программу, которая
// 1. Принимает на вход число (А). 
// 2 .Выдаёт сумму чисел от 1 до А.

// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i;
        }
    }

    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"{number} -> {sumNumbers}");