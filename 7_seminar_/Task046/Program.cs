//Задайте двумерный массив размером m x n,
//заполненный случайными числами.
Console.Clear();

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    { //matrix.GetLength(0 - строки | 1 - столбцы)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); //фактически используется полуинтервал [1; 10) поэтому "+ 1"
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { //matrix.GetLength(0 - строки | 1 - столбцы)
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

int[,] matrix = GetMatrix(rows, columns, 0, 9);
PrintMatrix(matrix);

