// 1. Задайте двумерный массив.
// 2. Напишите программу,которая заменяет строки на столбцы.
// 3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ReplacingRowWithColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temporary = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temporary;
        }
    }
    return matr;
}

int[,] matrix = CreateMatrixRandint(5, 5, 1, 10);

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    PrintMatrix(matrix);
    ReplacingRowWithColumns(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
}
else Console.WriteLine("Матрица не имеет форму квадрата.");