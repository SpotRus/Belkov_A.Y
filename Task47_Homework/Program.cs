// 1. Задайте двумерный массив размером m×n.
// 2. Заполненный случайными вещественными числами.

// Например:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] arr = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(minLimitRandom, maxLimitRandom + 1) + rand.NextDouble();
        }
    }
    return arr;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}\t");
        }
        Console.WriteLine();
    }

}

int m = 3;
int n = 4;
int minLimitRandom = -10;
int maxLimitRandom = 10;

double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(result);