//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
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

int[] NumsComposition(int[] array)
{
    int[] result = new int[(array.Length + 1) / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
        Console.WriteLine($"{result[i]} = {array[i]} * {array[array.Length - i - 1]}");
    }
    if(array.Length % 2 == 1) result[result.Length - 1] = array[array.Length / 2];
    return result;
}

int[] array = GetRandomArray(15, -20, 20);
Console.WriteLine($"[{String.Join(" | ", array)}]");
Console.WriteLine($"Произведения пар в массиве:");
int[] result = NumsComposition(array);
Console.Write($"[{String.Join(" | ", result)}]");