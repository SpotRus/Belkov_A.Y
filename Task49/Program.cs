// 1. Задайте двумерный массив. 
// 2. Найдите элементы, у которых оба индекса чётные. 
// 3. Замените эти элементы на их квадраты.

// Например, изначально массив      Новый массив будет выглядеть    
// выглядел вот так:                вот так:
// 1 4 7 2                          1   4   14   2
// 5 9 2 3                          5   9   2    3
// 8 4 2 4                          64  4   4    4

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

int[,] ReplacingEvenIndexesSquared(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 2)
    {
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            matr[i, j] *= matr[i, j];
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
            Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRandint(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReplacingEvenIndexesSquared(matrix);
PrintMatrix(matrix);
