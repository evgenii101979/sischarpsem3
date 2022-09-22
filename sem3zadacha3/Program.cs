// Задача 21: Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -  y1, 2));

Console.WriteLine($"Расстояние равно {Math.Round(r, 2)}");
