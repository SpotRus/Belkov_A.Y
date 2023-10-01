// Напишите программу, которая:
// 1. Выводит массив из 8 элементов. 
// 2. Заполненный нулями и единицами в случайном порядке.

// Например:
// [1,0,1,1,0,1,0,0]

void RandomArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = new Random().Next(2); // 2 - 1
        index++;
    }
}

void PrintArray(int[] printArray)
{
    string output = "[";
    for (int i = 0; i < printArray.Length; i++)
    {
        output += (i < printArray.Length - 1) ? $"{printArray[i]}, " : $"{printArray[i]}]";
    }
    Console.WriteLine(output);
}

int[] array = new int[8];

RandomArray(array);
PrintArray(array);
