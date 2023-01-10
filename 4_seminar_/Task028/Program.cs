//Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
Console.Clear();

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 1; i < 41; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {N} равна {GetSum(N)}.");

int GetSum (int limit)
{
    int composition = 1;
    for (int i = 1; i <= limit; i++)
    {
        composition = composition * i;
    }
    return composition;
}