// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ProductOfPairNumbers(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] productOfPair = new int[size];
    for (int i = 0; i < size; i++)
    {
        productOfPair[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0) productOfPair[size - 1] = arr[arr.Length / 2];
    return productOfPair;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($"{arr.Last()}]");
}

// void PrintArray2(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

int[] array = CreataArrarRange(4, 1, 10);
int[] array2 = ProductOfPairNumbers(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(array2);