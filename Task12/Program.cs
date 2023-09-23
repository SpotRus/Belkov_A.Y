// Напишите программу, которая: 
// 1. Будет принимать навход два числа 
// 2. Выводить, является ли первое числократным второму. 
// 3.Если первое число не кратно второму, то программа выводит остаток от деления.

// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetRemainder(int num1, int num2)
{
    return num1 % num2;
}

int firstNum = GetUserInput("Ведите первое число");
int secondNum = GetUserInput("Введите второе число");

int rem = GetRemainder(firstNum, secondNum);

if (rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondNum}");
}
else
{
    Console.WriteLine($"Число {firstNum} не кратно {secondNum}, остаток {rem}");
}