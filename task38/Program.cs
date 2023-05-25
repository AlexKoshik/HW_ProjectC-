// Задача 38: Задайте массив 
// вещественных чисел. Найдите 
// разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());


void RandomArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 99);
    }
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void DifNum(double[] arr)
{

    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.Write(max - min);
}


double[] array = new double[a];
RandomArr(array);
PrintArray(array);
DifNum(array);