//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;
using static System.Console;
Clear();

double[,] GetMatrix(int rows, int columns, double initValue, double valueCount)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().NextDouble() * valueCount + initValue;
        }
    }
    return result;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] matrix = GetMatrix(rows, columns, -5.0, 10.0);
PrintMatrix(matrix);