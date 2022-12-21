//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Clear();

//"короткое" решение
Console.Write("Введите число: ");
string N = Console.ReadLine();
int length = N.Length;
Console.Write($"Количество цифр = {length}");


//Математические решения
// int number = new Random().Next(1, 100000);
// Console.WriteLine($"Число {number}.");

// while(number != number %Convert.ToInt32(Math.Pow(10, index)))
// {
//     index++;
// }
// Console.WriteLine($"Число {number} имеет разрядность {i}.");

// int GetCountNums(int number)
// {
//     int i = 0;
//     for (; number != number % Convert.ToInt32(Math.Pow(10, i)); i++)
//         ;
//     return i;
// }

// Console.WriteLine($"Количество цифр = {GetCountNums(number)}.");
