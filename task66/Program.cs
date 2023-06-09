// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное цисло M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное цисло N: ");
int y = Convert.ToInt32(Console.ReadLine());


int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}
void PrintSum(int m, int n)
{
    Console.Write($"Сумма натуральных чисел от M до N равна: {Sum(m - 1, n)}");
}


PrintSum(x, y);