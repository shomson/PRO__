//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int FindPosNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]% 2 == 0) count += 1;
    }
    return count;
}

int[] array = GetRandomArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(" | ", array)}]");
Console.WriteLine($"Количество чёных чисел в массиве - {FindPosNums(array)}.");