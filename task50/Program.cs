// Задача 50. Напишите программу, 
// которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int InputNumber()
// {
//     int num = new Random().Next(5, 5);
//     return num;
// }

Console.WriteLine("Введите строку: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] arr)
{

    if (n < 0 | n > arr.GetLength(0) - 1 | m < 0 | m > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0} ", arr[n, m]);
    }
}
int row = 5, colums = 6;
int[,] array = new int[row, colums];
CraeteArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
FindNumber(array);
