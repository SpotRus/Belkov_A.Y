// Напишите программу, которая: 
// 1. Принимает на вход два числа 
// 2. Проверяет, является ли одно число квадратом другого.

// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsSquareTwoNum(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

int number1 = GetUserInput("Введите 1 число ");
int number2 = GetUserInput("Введите 2 число ");
bool isSquareTwoNum = IsSquareTwoNum(number1, number2);
Console.WriteLine(isSquareTwoNum ? $"{number1}, {number2} -> да" : $"{number1}, {number2} -> нет");