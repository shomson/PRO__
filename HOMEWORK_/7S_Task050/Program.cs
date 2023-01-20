//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
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

string FindCellValue(int rowNum, int columnNum, int[,] matrix)
{
    string result = string.Empty;
    if (&& rowNum <= matrix.GetLength(0) && columnNum <= matrix.GetLength(1))
    {
        result = "Значение элемента равно " + matrix[rowNum - 1, columnNum - 1].ToString() + ".";
    }
    else result = "Такой ячейки не существует.";
    return result;
}

WriteLine("Для получения значения внутри ячейки");
Write("введите номер строки массива: ");
int rowNum = int.Parse(ReadLine());
Write("А теперь номер столбца массива: ");
int columnNum = int.Parse(ReadLine());

int[,] matrix = GetMatrix(5, 5, 0, 9);
PrintMatrix(matrix);
WriteLine();
Write($"{FindCellValue(rowNum, columnNum, matrix)}");