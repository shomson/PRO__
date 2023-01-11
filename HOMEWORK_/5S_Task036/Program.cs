//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
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

void SumNotEvenPositions(int[] array)
{
    int sum = 0;
    if (array.Length > 1)
    {
        for (int i = 1; i < array.Length; i = i + 2)
        {
            sum += array[i];
        }
        Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}.");
    }
    else
    {
        Console.WriteLine($"В массиве НЕТ элементов на нечетных позициях.");
    }
}

int[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"[{String.Join(" | ", array)}]");
SumNotEvenPositions(array);
