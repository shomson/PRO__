Console.Clear(); //очистка терминала
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число Б: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberA} / {numberB}");

int sqrA = Convert.ToInt32(Math.Pow(numberA, 2));
if(sqrA == numberB) //или if(Math.Pow(numberA, 2) == numberB)
{
    Console.WriteLine("Число Б квадрат числа А");
}
else
{
    Console.WriteLine("Число Б НЕ квадрат числа А");
}
Console.WriteLine($"{Math.Pow(numberA, 2) == numberB}"); //в терминале отображается True/False