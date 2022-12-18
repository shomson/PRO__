Console.Clear();

int number = new Random().Next(10, 100);
Console.WriteLine($"Число {number}.");
int firstDecade = number %10;
int secondDecade = number / 10;
if(secondDecade == firstDecade)
{
    Console.WriteLine($"Числа {secondDecade} и {firstDecade} равны.");
}
else
{
    if(secondDecade > firstDecade)
    {
        Console.WriteLine($"Число {secondDecade} больше {firstDecade}.");
    }
    else
    {
        Console.WriteLine($"Число {firstDecade} больше {secondDecade}.");
    }
}