//Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// using System;
// using static System.Console;
Console.Clear();

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = (i + 1) + (j + 1);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);