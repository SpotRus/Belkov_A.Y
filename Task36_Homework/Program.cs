// 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumElementsOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum += arr[i];
    }
    return sum;
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

int[] array = CreataArrarRange(6, -20, 20);

PrintArray(array);
int result = SumElementsOddPositions(array);
Console.WriteLine($" -> {result}");