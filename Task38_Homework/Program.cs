// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// Например:
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreataArrarRangeDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.NextDouble() * (max - min) + min;
    }
    return arr;
}

double[] DiffMaxMinElement(double[] arr)
{
    double maxNum = arr[0];
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
        if (arr[i] < minNum) minNum = arr[i];
    }
    double diffMaxMin = maxNum - minNum;
    return new double[] { maxNum, minNum, diffMaxMin };
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]:F2}, ");
    }
    Console.Write($"{arr.Last():F2}]");
}


double[] array = CreataArrarRangeDouble(5, 1, 100);

PrintArray(array);
double[] result = DiffMaxMinElement(array);

Console.WriteLine($" => {result[0]:F2} - {result[1]:F2} = {result[2]:F2}");
