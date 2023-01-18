//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//и замените эти элементы на их квадраты.
using System;
using static System.Console;
Clear();

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); //фактически используется полуинтервал [1; 10) поэтому "+ 1"
        }
    }
    return result;
}

void ChangeEven(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if((i + 1) %2 == 0 && (j + 1) %2 == 0)
            Write($"{matr[i, j] * matr[i, j]} ");
            else Write($"{matr[i, j]} ");
        }
        WriteLine();
    }
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

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] matrix = GetMatrix(rows, columns, -9, 9);
PrintMatrix(matrix);
WriteLine();
ChangeEven(matrix);