//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
using System;
using static System.Console;

Clear();

string PrintNumbers(int startNum, int endNum)
{
    if (endNum == startNum) return $"{startNum}";
    return (PrintNumbers(startNum, endNum - 1) + ' ' + endNum.ToString());
}

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));