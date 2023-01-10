//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
Console.Clear();

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]"); //команда String.Join("знаки", название массива) на вход принимает массив и расставляет знаки между элементами массива

int[] GetBinaryArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

// void ArrayRandom(int size)
// {
//     int[] array = new int[size];
//     // int size = array.Length;

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]} ");
//     }
// }

// int length = int.Parse(Console.ReadLine());
// ArrayRandom(length);

