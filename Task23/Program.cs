// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
double i = 1;
double result = 1;
Console.Write($"{a}=> ");
while (i <= a)
{
    result = Math.Pow(i, 3);
    Console.Write($"{result}, ");
    i++;
}
