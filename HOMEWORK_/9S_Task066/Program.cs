//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;
using static System.Console;

Clear();

int SumNumbers(int startNum, int endNum)
{
    if (endNum == startNum) return startNum;
    int sum = SumNumbers(startNum, endNum - 1) + endNum;
    return sum;
}

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(SumNumbers(m, n));