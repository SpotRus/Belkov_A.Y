// 1. Задайте двумерный массив размера m на n.
// 2. Каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// 3. Выведите полученный массив на экран.

// Например:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumIndexs(int rows, int columns)
{
    int[,] matr = new int[rows, columns];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine($"m = {matr.GetLength(0)}, n = {matr.GetLength(1)}.");

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixSumIndexs(3, 4);
PrintMatrix(matrix);