// 1. Задайте двумерный массив размером m×n.
// 2. Заполненный случайными целыми числами.

// Например:
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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

void PrintMatrix(int[,] matr)
{
    Console.WriteLine($"m = {matr.GetLength(0)}, n = {matr.GetLength(1)}.");

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 4}");
        }
        Console.WriteLine();
    }
}


int[,] matrix = CreateMatrixRandint(3, 4, -100, 100);
PrintMatrix(matrix);