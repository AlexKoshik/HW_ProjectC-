// Задача 34: Задайте массив заполненный
//  случайными положительными трёхзначными
//   числами. Напишите программу, которая 
//   покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
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
void CountSearchEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine(count);
}
int[] array = new int[6];
RandomArr(array);
PrintArray(array);
CountSearchEvenNum(array);