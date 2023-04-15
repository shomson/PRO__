//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
using System;
using static System.Console;

Clear();

// void NumbersRow(int num)
// {
//     if (num >= 1)
//     {
//         Write($"{num} ");
//         NumbersRow(num - 1);
//     }
// }
// 
// NumbersRow(7);

string PrintNumbers(int endNum)
{
    if (endNum == 1) return "1";
    return (PrintNumbers(endNum - 1) + ' ' + endNum.ToString());
}

Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(n));