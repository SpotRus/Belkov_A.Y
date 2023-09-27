// Напишите программу, которая:
// 1. Принимает на вход число (N). 
// 2. Выдаёт таблицу квадратов чисел от 1 до N.

void SquareNumbers (int num) 
{
    int count = 1;
    while (count <= num) {
        Console.WriteLine($"{count, 3} -> {count * count, 5}");
        count++;
    }
}

Console.Write ("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
SquareNumbers(userNum);