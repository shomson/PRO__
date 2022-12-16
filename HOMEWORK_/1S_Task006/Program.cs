//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int N = number%2; //% - (аргумент/оператор/функция) для вывода остатка от деления

if(N == 0)
{
   Console.WriteLine($"Число {number} - четное.");
}

else
{
    Console.WriteLine($"Число {number} - НЕ четное."); 
}