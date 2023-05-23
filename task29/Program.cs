// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void RandomArr(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = new int[8];
RandomArr(array);
PrintArray(array);