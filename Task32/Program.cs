//  Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void GetReplacArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // arr[i] *= -1;
        arr[i] = -arr[i];
    }
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

int[] array = CreataArrarRange(4, -9, 9);

PrintArray(array);
Console.Write(" -> ");
GetReplacArray(array);
PrintArray(array);