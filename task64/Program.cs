// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 1)
{
Console.WriteLine("Введено неверное число, перезапустите программу и повторите ввод!");
}
else
{
    Massive(1, x);
}

void Massive(int start, int end)
{
if(end == start) Console.Write($"{end}, ");
else
{
Massive(start + 1, end);
Console.Write($"{start}, ");
}
}

