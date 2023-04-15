//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
using System;
using static System.Console;

Clear();

int PrintSum(int num)
{
    if (num == 0)
    {
        WriteLine($"0 ");
        return 0;
    }
    int sum = num % 10 + PrintSum(num / 10);
    WriteLine($"{sum} ");
    return sum;
}

Write("Введите число: ");
int num = int.Parse(ReadLine());

WriteLine($"{num} -> {PrintSum(num)}");