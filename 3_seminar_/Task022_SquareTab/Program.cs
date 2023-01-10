//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} -> {Math.Pow(i, 2)}");
}