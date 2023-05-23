// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 99);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void SumElOdPos(int[] arr)
{
    for (int i = 1; i < arr.Length ; i++)
    {
        int sum = arr[i] + arr[i + 2];
        Console.WriteLine($"{sum} ");
    }
}

int[] array = new int[4];
RandomArr(array);
PrintArray(array);
SumElOdPos(array);