// 1. Задайте значение N.
// 2. Напишите программу, которая выведет все натуральные числа в промежутку от 1 до N.

string CounterPlus(int n)
{

    return (n != 0) ? CounterPlus(n - 1) + $"{n,2} " : String.Empty;
}

int GetInputUser(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int userInput = GetInputUser("Введите натуральное число: ");

if (userInput < 0) Console.WriteLine("Некорректный ввод.");

Console.WriteLine(CounterPlus(userInput));