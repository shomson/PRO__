//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до M.
using System;
using static System.Console;

Clear();

string PrintNumbers(int startNum, int endNum)
{
    if (startNum < endNum)
    {
        return (endNum.ToString() + ' ' + PrintNumbers(startNum, endNum - 1));
    }
    else
    {
        if (endNum == startNum) return $"{startNum}";
        return (PrintNumbers(startNum - 1, endNum) + ' ' + startNum.ToString());
    }
    
}

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));