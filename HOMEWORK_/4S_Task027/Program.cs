//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

Console.Write("Введите положительное число: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Сумма цифр числа {number} равна {GetNumsSum(number)}.");

int GetNumsSum(int number)
{
    int sum = 0;
    int remainder = 0;
    while(number > 0)
        {
            remainder = number %10;
            number = number / 10;
            sum = sum + remainder;
        }
    return sum;
}

