// Напишите программу, которая:
// 1. Принимает на вход число N.
// 2. Выдаёт произведение чисел от 1 до N.

// Например:
// 4 -> 24
// 5 -> 120

int MultiNumbers(int num)
{
    int sum = 1;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum *= i;
        }
    }

    return sum;
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiNumbers = MultiNumbers(number);
Console.WriteLine($"{number} -> {multiNumbers}");