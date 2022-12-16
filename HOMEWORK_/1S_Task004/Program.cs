//Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if(numberA > numberB)
{
    if(numberA > numberC)
    {
        Console.WriteLine($"MAX = {max}");
    }

    else
    {
        max = numberC;
        Console.WriteLine($"MAX = {max}");
    }
}

else
{
    max = numberB;
    if(numberB > numberC)
    {
        Console.WriteLine($"MAX = {max}");
    }

    else
    {
        max = numberC;
        Console.WriteLine($"MAX = {max}");
    }
}

//2 вариант
Console.Write("Введите число A: ");
int numberA2 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB2 = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC2 = int.Parse(Console.ReadLine());

int max2 = numberA2;

if(numberA2 > numberB2)
{
    if(numberA2 > numberC2);

    else
    {
        max2 = numberC2;
    }
}

else
{
    max2 = numberB2;
    if(numberB2 > numberC2);

    else
    {
        max2 = numberC2;
    }
}
Console.WriteLine($"MAX = {max2}");