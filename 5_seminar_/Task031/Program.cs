//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
Console.Clear();

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine($"[{String.Join(" | ", array)}]"); 

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) //foreach(int el in array) возможно заменить for условием foreach - перебирает каждый элемент внутри массива
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumPosNums = 0;
int SumNegNums = 0;

for (int j = 0; j < array.Length - 1; j++)
{
    if(array[j] >= 0) SumPosNums += array[j];
    else SumNegNums += array[j];
}

Console.WriteLine($"Сумма положительных чисел массива равна {SumPosNums}, сумма отрицательных {SumNegNums}.");