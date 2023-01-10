//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) //foreach(int el in array) возможно заменить for условием foreach - перебирает каждый элемент внутри массива
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"[{String.Join(" | ", array)}]"); 

for (int j = 0; j < array.Length; j++)
{
    array[j] *= -1;
}
Console.WriteLine($"[{String.Join(" | ", array)}]");