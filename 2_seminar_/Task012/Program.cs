//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

// нужна проверка numberB на НОЛЬ

int remainder = numberA % numberB;

if(remainder == 0)
{
    Console.WriteLine($"Число {numberA} кратно {numberB}.");
}
else
{
    Console.WriteLine($"Число {numberA} НЕ кратно {numberB}, остаток {remainder}.");
}