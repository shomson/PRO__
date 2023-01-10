Console.Clear();

// string[,] table = new string[2, 5];
// //String.Empty - по умолчанию
// // table[0, 0] table[0, 1] ... table[0, 4]
// // table[1, 0] table[1, 1] ... table[1, 4]

// table[1, 3] = "c";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($" {table[rows, columns]}|");
//     }
//     Console.WriteLine();
// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    { //matrix.GetLength(0 - строки | 1 - столбцы)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    { //matrix.GetLength(0 - строки | 1 - столбцы)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //фактически используется полуинтервал [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);