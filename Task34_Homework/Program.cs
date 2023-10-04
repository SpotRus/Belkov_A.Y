// 1. Задайте массив заполненный случайными положительными трёхзначными числами.
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// Например:
// [345, 897, 568, 234] -> 2

int[] CreataArrarRange(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr.Last()}]");
}

int[] array = CreataArrarRange(4, 100, 999);
PrintArray(array);
int result = EvenNumbers(array);
Console.WriteLine($" -> {result}");