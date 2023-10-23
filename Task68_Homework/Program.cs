// 1. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// 2. Даны два неотрицательных числа m и n.

// Например:
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetInputUser(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    if ((m != 0) && (n == 0))
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

int userNumberM = GetInputUser("Введите первое число: ");
Console.WriteLine();

int userNumberN = GetInputUser("Введите второе число: ");
Console.WriteLine();

Console.WriteLine($"m = {userNumberM}, n = {userNumberN} -> A(m,n) = {Ackerman(userNumberM, userNumberN)}");