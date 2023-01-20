//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

void ReplaceRowsColumns(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                int buffer = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = buffer;
            }
        }
        PrintMatrix(matrix);
    }
    else WriteLine("Невозможно поменять строки и столбцы местами!");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, 0, 9);
PrintMatrix(matrix);
WriteLine();
ReplaceRowsColumns(matrix);
//PrintMatrix(matrix);
