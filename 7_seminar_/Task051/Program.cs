//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
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

int DiagonalSum(int[,] matr)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == j)
            result = result + matr[i, j];
        }
    }
    return result;
}

int GetDiagonalSum(int[,] matr)
{
    int result = 0;
    int length = matr.GetLength(0) < matr.GetLength(1) ? matr.GetLength(0) : matr.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        result += matr[i, i];
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

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] matrix = GetMatrix(rows, columns, -9, 9);
PrintMatrix(matrix);
WriteLine();
Write($"Сумма элементов на главной диагонали равна {DiagonalSum(matrix)} / ");
Write($"{GetDiagonalSum(matrix)}.");