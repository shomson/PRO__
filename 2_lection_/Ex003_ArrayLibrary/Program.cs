Console.Clear();

void FillArray(int[] collection) //void - функция (С# - метод), которая(ый) не возвращает значения
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //генератор случайных чисел
        index++;
    }
    
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] col, int find)
{
    int count = col.Length;
    int index = 0;
    int position = -1; //изящное решение, если элемент массива с нужным значением будет НЕ найден
    while(index < count)
    {
        if(col[index] == find)
        {
            position = index;
            break; //условие покажет первое встретившееся значение и остановит цикл
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //сначала определили массив из 10 элементов (по умолчанию значения всех чисел равно 0)

FillArray(array); //вызвали метод, который заполнил наш массив array
PrintArray(array); //вызвали метод, который вывел на экран наш массив 
Console.WriteLine();

int pos = IndexOf(array, 6); //если pos = -1, значит метод не нашел искомого значения
if(pos == -1)
{
    Console.WriteLine("Искомое значение НЕ найдено.");
}
else
{
    Console.WriteLine($"Первый элемент массива с искомым значением находиться в ячейке {pos}.");
}