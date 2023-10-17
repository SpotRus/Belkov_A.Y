// 1. Составить частотный словарь элементов двумерного массива.
// 2. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Набор данных                                    Частотный массив

// 1, 2, 3                                         1 встречается 3 раза
// 4, 6, 1                                         2 встречается 2 раз
// 2, 1, 6                                         3 встречается 1 раз
//                                                 4 встречается 1 раз
//                                                 6 встречается 2 раза

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
            Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    Console.Write("{");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine(arr.Last() + "}");
}

int[] MatrixToArray(int[,] matr)
{
    int[] arr = new int[matr.Length];
    int count = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[count] = matr[i, j];
            count++;
        }
    }
    return arr;
}

void FrequencyDictionary(int[] arr)
{
    int count = 1;
    int сurrentNum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == сurrentNum) count++;
        else
        {
            if (count > 1 && count < 5)
            {
                Console.WriteLine($"{сurrentNum} встречается {count} раза.");
                сurrentNum = arr[i];
                count = 1;
            }
            else
            {
                Console.WriteLine($"{сurrentNum} встречается {count} раз.");
                сurrentNum = arr[i];
                count = 1;
            }
        }
    }
    Console.WriteLine((count > 1 && count < 5)
    ? $"{сurrentNum} встречается {count} раза."
    : $"{сurrentNum} встречается {count} раз.");
}

int[,] matrix = CreateMatrixRandint(3, 3, 0, 9);
PrintMatrix(matrix);

Console.WriteLine();

int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(array);