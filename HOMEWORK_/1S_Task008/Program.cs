//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число от 1 до 100: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Все четные числа в интервале от 1 до {N}:");
int index = 1;

while (index < N) //для примера в интервале (1, N) НЕ включая N
{
    if(index%2 == 0)
    {
        Console.Write($"{index} ");
    }
    index++;
}