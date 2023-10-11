// 1. Задайте двумерный массив из целых чисел.
// 2. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] matrix)
{
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

void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:f2}\t");
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arr[j] += matrix[i, j];
        }
        arr[j] /= matrix.GetLength(0);
    }
    return arr;
}

int n, m, k;

n = 3;
m = 4;
k = 1;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));