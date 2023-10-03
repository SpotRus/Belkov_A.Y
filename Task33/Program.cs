// 1. Задайте массив. 
// 2. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreataArrarRange(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

int UserInput(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr.Last()}]");
}

bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int[] array = CreataArrarRange(5, -10, 10);

int number = UserInput("Введите число: ");

PrintArray(array);

bool findNumber = FindNumber(array, number);

Console.WriteLine(findNumber ? " -> да" : " -> нет");