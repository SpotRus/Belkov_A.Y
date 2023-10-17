// 1. Задайте двумерный массив.
// 2. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ReplacingFirstLineOnTheLast(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int temporary = matr[0, j];
        matr[0, j] = matr[matr.GetLength(0) - 1, j];
        matr[matr.GetLength(0) - 1, j] = temporary;
    }
    return matr;

}

int[,] matrix = CreateMatrixRandint(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReplacingFirstLineOnTheLast(matrix);
PrintMatrix(matrix);
