// Задайте массив из 12 элементов: 
// 1. Заполненный случайными числами из промежутка [-9, 9].
// 2. Найдите сумму отрицательных и положительных элементов массива.

// Например: 
// В массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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

void PrintArray(int[] arr)
{
    Console.Write("В массиве [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("] сумма");
}

// int[] GetSumPositiveNegativeElem(int[] arr)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPositive += arr[i];
//         else sumNegative += arr[i];
//     }
//     return new int[] { sumPositive, sumNegative };
// }
int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreataArrarRange(12, -9, 9);

PrintArray(array);

// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"положительных чисел равна {sumPositiveNegativeElem[0]}, сумма отрицательных равна");
// Console.WriteLine($"{sumPositiveNegativeElem[1]}.");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);

Console.WriteLine($"положительных чисел равна {sumPositiveElem}, сумма отрицательных равна");
Console.WriteLine($"{sumNegativeElem}.");