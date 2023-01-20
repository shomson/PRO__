//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
using System;
using static System.Console;
Clear();

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        
    WriteLine();
    }
}

void ReplaceRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < 1; i++)
        {
            int buffer = matrix[i, j];
            matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
            matrix[matrix.GetLength(0) - i - 1, j] = buffer;
        }
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, 0, 9);
PrintMatrix(matrix);
WriteLine();
ReplaceRows(matrix);
PrintMatrix(matrix);