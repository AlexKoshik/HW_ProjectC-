// Задача 56: Задайте прямоугольный 
// двумерный массив. Напишите программу, 
// которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму 
// элементов в каждой строке 
// и выдаёт номер строки 
// с наименьшей суммой элементов: 
// 1 строка

// создаём прямоугольный массив
int[,] table = new int[4, 4];
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
// метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Находим строку с наименьшей суммой элементов
void MinLineSumElements(int[,] array)
{
    int minLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minLine += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumLine += table[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minSumLine + 1} строка");
}


CreateArray(table);
PrintArray(table);
MinLineSumElements(table);