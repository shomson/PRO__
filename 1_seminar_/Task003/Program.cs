//Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число от 0 до 10: ");
int N = int.Parse(Console.ReadLine());
int meanN = -N;

while (meanN <= N)
{
    Console.Write($"{meanN} ");
    meanN++;
}