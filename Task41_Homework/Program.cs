// 1. Пользователь вводит с клавиатуры M чисел.
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Например:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3


int EnteringMNumbers(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] PositiveNumbers(int num)
{
    // int count = 1;
    int usNum = 0;
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        usNum = EnteringMNumbers($"Введите число № {i + 1}: ");
        arr[i] = usNum;
        // count++;
        Console.WriteLine();
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr.Last()}");
}

int CheckingPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int numberOfNumbers = EnteringMNumbers("Введите колисто чисел для ввода: ");

Console.WriteLine();

int[] userArray = PositiveNumbers(numberOfNumbers);
PrintArray(userArray);
int quantityPositiveNumbers = CheckingPositiveNumbers(userArray);

Console.WriteLine($" -> {quantityPositiveNumbers}");