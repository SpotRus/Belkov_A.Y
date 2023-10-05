// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray(int[] arr)
{
    // Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    // Console.Write($"{arr.Last()}]");
}

int[] Fibonacci(int n)
{
    int[] arr = new int[n];
    //arr[0]=0;
    arr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;

}

int number = GetUserInput("Введите N больше либо равное 2: ");
if (number < 2)
{
    Console.WriteLine("Некоректный ввод");
    return;
}

int[] array = Fibonacci(number);
Console.WriteLine();
Console.Write($"Если N = {number} -> ");
PrintArray(array);
Console.WriteLine();