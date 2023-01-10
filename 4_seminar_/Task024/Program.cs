//Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {N} равна {GetSum(N)}.");

int GetSum (int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}