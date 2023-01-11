//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
Console.Clear();

Console.WriteLine("Введите значения длины каждой стороны треугольника.");
Console.Write("Cторона A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Cторона B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Cторона C: ");
int c = int.Parse(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return (a + b) > c && (b + c) > a && (c + a) > b;
}

if(Triangle(a, b, c)) Console.WriteLine("Треугольник с такими сторонами существует.");
else Console.WriteLine("Треугольник с такими сторонами НЕ существует.");