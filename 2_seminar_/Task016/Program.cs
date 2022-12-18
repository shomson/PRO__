//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
Console.Clear();

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число Б: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"{numberA} / {numberB}");

int sqrA = Convert.ToInt32(Math.Pow(numberA, 2));
int sqrB = Convert.ToInt32(Math.Pow(numberB, 2));

if((sqrA == numberB) || (sqrB == numberA))
{
    Console.WriteLine("Одно из чисел квадрат другого.");
}
else
{
    Console.WriteLine("Ни одно из чисел НЕ является квадратом другого.");
}
