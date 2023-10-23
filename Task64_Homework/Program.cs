// 1. Задайте значение N.
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// 3. Выполнить с помощью рекурсии.

// Например:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetInputUser(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string CounterMinus(int num)
{
    if (num == 0) return String.Empty;
    else if (num > 0) return $"{num}, " + CounterMinus(num - 1);
    else return $"Некорректный ввод.  ";
}

int userNumber = GetInputUser("Введите натуральное число: ");

if (userNumber < 1) Console.WriteLine("Некорректный ввод.");

string result = CounterMinus(userNumber);
int resultTemp = result.Length - 2;
result = result.Remove(resultTemp);

Console.Write($"N = {userNumber} -> ");
Console.Write('"' + result + '"');
