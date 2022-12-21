//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(" | ", array)}]"); 

// int[] GetBinaryArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }

void ArrayRandom(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Напишите кол-во элементов в массиве: ");
int length = int.Parse(Console.ReadLine());
ArrayRandom(length);
