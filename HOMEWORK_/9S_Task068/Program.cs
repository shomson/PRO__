//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
using System;
using static System.Console;

Clear();

int AckermannFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunc(m - 1, 1);
    else return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

Console.Write($"Функция Аккермана = {AckermannFunc(m, n)}");