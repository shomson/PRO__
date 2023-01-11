//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] GetRandomArray(int size, double initValue, double valueCount)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * valueCount + initValue; 
    }
    return array;
}

void FindMinMaxDiff(double[] array)
{ 
    if (array.Length > 1)
    {
        double min = array[0];
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                continue;
            }
            if (array[i] > max) max = array[i];
        }
        Console.WriteLine($"MIN = {Math.Round(min, 5)}, MAX = {Math.Round(max, 5)}.");
        Console.Write("Разница между MIN и MAX элементами массива равна");
        Console.WriteLine($" {Math.Round(max - min, 5)}.");
    }
    else
    {
        Console.WriteLine($"В массиве всего ОДИН элемент.");
    }
}

double[] array = GetRandomArray(5, -2.5, 5.0);
Console.WriteLine($"[{String.Join(" | ", array)}]");
FindMinMaxDiff(array);