//При вводе любого числа необходимо отобразить последнюю цифру.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int N = number%100; //% - (аргумент/оператор/функция) для вывода остатка от деления

int number2 = number / 100;

int N2 = number2%10;

Console.WriteLine($"{N2}");