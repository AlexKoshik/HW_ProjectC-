// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int num = ExpNum();
int ExpNum()
{
    int result=a;
    int count = 1;
    for (int i = a; count <= b; count++)
    {   
        result = result * result;
    }
    return result;
}
Console.WriteLine(num);