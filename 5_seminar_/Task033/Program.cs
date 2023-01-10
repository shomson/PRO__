//Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

bool FindNum(int num, int[] array)
{
    foreach(int el in array)
    {
        if(num == el)
        return true;
    }
    return false;
}

int[] array = GetRandomArray(10, 1, 10);
int num = 5;

Console.WriteLine($"[{String.Join(" | ", array)}]");
if(FindNum(num, array)) Console.WriteLine($"Число {num} - найдено.");
else Console.WriteLine($"Число {num} - НЕ найдено.");