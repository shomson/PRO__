Console.Clear();
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число Б: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA == numberB)
{
    Console.WriteLine("Числа А и Б - равны.");
}

else
{
    if(numberA < numberB)
    {
        Console.WriteLine($"MIN(А) = {numberA}, MAX(Б) = {numberB}");
    }

    else
    {
        Console.WriteLine($"MIN(Б) = {numberB}, MAX(А) = {numberA}");
    }
}