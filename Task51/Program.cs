// 1. Задайте двумерный массив.
// 2. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д).

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

int[,] CreateMatrixRandint(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(min, max + 1);
        }
    }
    return matr;
}

int SumElementsMainDiagonal(int[,] matr)
{
    int sum = 0;
    int min = matr.GetLength(0);
    if (min > matr.GetLength(1)) min = matr.GetLength(1);

    for (int i = 0; i < min; i++)
    {
        sum += matr[i, i];
    }
    return sum;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRandint(5, 6, 1, 20);
PrintMatrix(matrix);
Console.WriteLine();
int result = SumElementsMainDiagonal(matrix);
Console.WriteLine($"Сумма элементов главной диагонали {result}");
