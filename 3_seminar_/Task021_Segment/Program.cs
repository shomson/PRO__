//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
Console.Clear();

Console.Write("Введите координаты X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y2: ");
int y2 = int.Parse(Console.ReadLine());

double segment = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.Write($"A ({x1}, {y1}); B ({x2}, {y2}) -> {Math.Round(segment, 2)}");