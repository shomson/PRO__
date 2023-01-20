//Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j]; //либо result[i * matrix.GetLength(1) + j] = matrix[i, j], без переменной index
            index++;
        }
    }
    return result;
}

void SelectionSort(int[] array) //цикл сортировки Min -> Max
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) //сортировка меняется в зависимости от знака в условии
                minPosition = j;
        }
        int buffer = array[i];
        array[i] = array[minPosition];
        array[minPosition] = buffer;
    }
}

void ElementsValueCount(int[] array)
{
    int elem = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == elem)
        {
            count++;
        }
        else
        {
            WriteLine($"{elem} встречается {count} раз(а)");
            elem = array[i];
            count = 1;
        }
    }
    WriteLine($"{elem} встречается {count} раз(а)");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, 0, 9);
PrintMatrix(matrix);
WriteLine();
int[] array = MatrixToArray(matrix);
WriteLine($"{String.Join(" | ", array)}");
SelectionSort(array);
WriteLine($"{String.Join(" | ", array)}");
ElementsValueCount(array);