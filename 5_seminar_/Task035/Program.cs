//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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

int FindNums(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min <= array[i] && array[i] <= max)
            count += 1;
    }
    return count;
}

int[] array = GetRandomArray(10, -100, 100);
Console.WriteLine($"[{String.Join(" | ", array)}]");
int count = FindNums(array, 10, 99);
Console.WriteLine($"Количество элементов в отрезке [10, 99] - {count}.");
