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

int SumNotEvenPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"[{String.Join(" | ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях равна {SumNotEvenPositions(array)}.");