//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
using System;
using static System.Console;

Clear();

int NumberDegree(int num, int deg)
{
    if (deg == 0) return 1;
    return (num * NumberDegree (num, deg - 1));
}

Write("Введите A: ");
int a = int.Parse(ReadLine());
Write("Введите B: ");
int b = int.Parse(ReadLine());

WriteLine(NumberDegree(a, b));