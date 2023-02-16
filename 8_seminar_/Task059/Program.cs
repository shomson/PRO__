//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
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

int[,] DeleteMinValue(int[,] matrix)
{
    int minValue = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    WriteLine($"minValue {minValue} / minRow {minRow} / minColumn {minColumn}");

    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int k = 0; k < result.GetLength(0); k++)
    {
        int i = 0;
        if (i == minRow) i =+ 1;
        for (int l = 0; l < result.GetLength(1); l++)
        {
            int j = 0;
            if (j == minColumn) j += 1;
            result[k, l] = matrix[i, j];
            j++;
        }
        i++;
    }
    return result;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, 0, 9);
PrintMatrix(matrix);
WriteLine();
int[,] minMatrix = DeleteMinValue(matrix);
PrintMatrix(minMatrix);

