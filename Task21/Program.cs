// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x точки а : ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки а : ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки а : ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки b : ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки b : ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки b : ");
double z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+ Math.Pow((z2-z1), 2));
Console.WriteLine($"Расстояние между a и b = {Math.Round(distance, 3)}");
