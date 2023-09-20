// Напишите программу, которая будет: 
// 1. Выдавать название дня недели. 
// 2. По заданному номеру.

// Например:

// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели ");
string number = Console.ReadLine();

if (number == "1")
{
    Console.Write(number + " -> Понедельник");
}
else if (number == "2")
{
    Console.Write(number + " -> Вторник");
}
else if (number == "3")
{
    Console.Write(number + " -> Среда");
}
else if (number == "4")
{
    Console.Write(number + " -> Четверг");
}
else if (number == "5")
{
    Console.Write(number + " -> Пятница");
}
else if (number == "6")
{
    Console.Write(number + " -> Суббота");
}
else if (number == "7")
{
    Console.Write(number + " -> Воскресенье");
}
else
    Console.WriteLine("Введите номер от 1 до 7.");