// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int UserNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateCustomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr.Last()}]");
}

int[] DuplicateArray(int[] array)
{
    int[] duplicateArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        duplicateArray[i] = array[i];
    }
    return duplicateArray;
}

int userSize = UserNumber("Введите размер массива: ");
int userMin = UserNumber("Введите минимальную цифру для диапазона: ");
int userMax = UserNumber("Введите максимальную цифру для диапазона: ");
Console.WriteLine();
int[] userArray = CreateCustomArray(userSize, userMin, userMax);
PrintArray(userArray);
int[] newArray = DuplicateArray(userArray);
// newArray[1] = 2000;
PrintArray(newArray);
