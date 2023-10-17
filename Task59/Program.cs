// 1. Задайтедвумерный массив из целых чисел.
// 2. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] IndexSmallerNumber(int[,] matr)
{
    int rowMin = 0;
    int colMin = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < matr[rowMin, colMin])
            {
                rowMin = i;
                colMin = j;
            }
        }
    }
    return new int[] { rowMin, colMin };
}

int[,] MatrixRowColDel(int[,] matr, int rowDel, int colDel)
{
    int[,] resMatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int row = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i != rowDel)
        {
            int col = 0;

            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j != colDel)
                {
                    resMatr[row, col] = matr[i, j];
                    col++;
                }
            }
            row++;
        }
    }
    return resMatr;
}

int[,] matrix = CreateMatrixRandint(5, 6, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = IndexSmallerNumber(matrix);
Console.WriteLine($"{array[0]}, {array[1]}. -> {matrix[array[0], array[1]]}");
int[,] resMatrix = MatrixRowColDel(matrix, array[0], array[1]);

Console.WriteLine();
PrintMatrix(resMatrix);