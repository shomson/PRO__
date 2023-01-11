//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int buffer = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = buffer;
    }
}

int[] ReverseArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int j = 0; j < inArray.Length; j++)
    {
        result[j] = inArray[inArray.Length - j - 1];
    }
    return result;
}

int[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"[{String.Join(" | ", array)}]");

int[] reverseArr = ReverseArray2(array);
Console.WriteLine($"[{String.Join(" | ", reverseArr)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(" | ", array)}]");