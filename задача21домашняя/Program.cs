// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите x точки A: ");
double dotAx = double.Parse(Console.ReadLine());

Console.Write("Введите y точки A: ");
double dotAy = double.Parse(Console.ReadLine());
Console.Write("Введите x точки B: ");
double dotBx = double.Parse(Console.ReadLine());
Console.Write("Введите y точки B: ");
double dotBy = double.Parse(Console.ReadLine());
Console.Write("Введите x точки Z: ");
double dotZx = double.Parse(Console.ReadLine());
Console.Write("Введите y точки Z: ");
double dotZy = double.Parse(Console.ReadLine());

double distanse = Math.Sqrt((dotBx - dotAx) * (dotBx - dotAx) + (dotBy - dotAy) * (dotBy - dotAy) + (dotZy - dotZy) * (dotZy - dotZy));

Console.WriteLine($"{distanse:f2}"); 