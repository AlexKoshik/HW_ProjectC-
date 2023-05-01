// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите  пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 10 == num / 10000)
{
    while (num >= 99)
    {
        num /= 10;
    }
    num = num % 10;
    int a = num;
    while (num >= 9999)
    {
        num /= 10;
    }
    num = num % 10;
    int b = num;
    if (a==b)
    {
        Console.WriteLine(" да ");
    }
}
else
{
    Console.WriteLine(" нет ");
}