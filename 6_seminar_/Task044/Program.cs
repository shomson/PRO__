//Не используя рекурсию, выведите первые N чисел Фибоначчи.
Console.Clear();

int[] Fibonacci(int N)
{
    int[] result = new int[N];
    for (int i = 0; i < N; i++)
    {
        result[i] = i;
        if (i == 1) break;
    }

    if (N > 2)
        {
            for (int j = 2; j < N; j++)
            {
             result[j] = result[j - 2] + result[j - 1];  
            }
        }
    return result;
}

Console.WriteLine("Сколько чисел Фибоначчи вы хотите увидеть?");
int number = int.Parse(Console.ReadLine());
int[] fibonacciArray = Fibonacci(number);
Console.WriteLine($"[{String.Join("_", fibonacciArray)}]");
