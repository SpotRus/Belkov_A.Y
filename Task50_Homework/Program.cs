// Напишите программу, которая:
// 1. На вход принимает позиции элемента в двумерном массиве.
// 2. Возвращает значение этого элемента или же указание, что такого элемента нет.

// Например:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    // Введите свое решение ниже
    int[,] arr = new int[n, m];
    int count = 1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = count;
            count += k;
        }
    }
    return arr;

}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    // Введите свое решение ниже
    int[] num = { 0, -1 };

    if (rowPosition < matrix.GetLength(0) & columnPosition < matrix.GetLength(1))
    {
        num[0] = matrix[rowPosition, columnPosition];
        num[1] = 0;
    }
    return num;
}

void PrintCheckIfError(int[] results, int X, int Y)
{
    // Введите свое решение ниже
    if (results[1] == -1) Console.WriteLine("There is no such index");
    else Console.Write($"The number in [{X}, {Y}] is {results[0]}");
}


int n = 4;
int m = 5;
int k = 2;
int x = 8;
int y = 0;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
