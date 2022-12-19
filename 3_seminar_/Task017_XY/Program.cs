//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();

Console.Write("Введите координаты X (=/= 0): ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y (=/= 0): ");
int y = int.Parse(Console.ReadLine());

if(x == 0 || y == 0)
{
    Console.WriteLine("Точка находится на оси.");
}
if(x > 0 && y > 0) Console.WriteLine("Точка находится в 1-ой четверти плоскости.");
if(x > 0 && y < 0) Console.WriteLine("Точка находится в 4-ой четверти плоскости.");
if(x < 0 && y > 0) Console.WriteLine("Точка находится во 2-ой четверти плоскости.");
if(x < 0 && y < 0) Console.WriteLine("Точка находится в 3-ей четверти плоскости.");
