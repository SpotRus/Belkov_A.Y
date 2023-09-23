// Напишите программу, которая: 
// 1. Принимает на вход число 
// 2. Проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool DivisionTo7and23(int num, int num1, int num2)
{
    // return num % 7 == 0 && num % 23 == 0;
    return num % num1 == 0 && num1 % num2 == 0;
}

int number = GetUserInput("Введите число: ");
int number1 = GetUserInput("Введите первый делитель: ");
int number2 = GetUserInput("Введите второй делитель: ");
bool result = DivisionTo7and23(number, number1, number2);

Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");