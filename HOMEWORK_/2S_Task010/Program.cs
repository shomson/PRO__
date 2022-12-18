//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.Clear();

int number = new Random().Next(100, 1000);
Console.Write($"{number} -> ");

int middleNumber(int number) //создание метода для тренировки
{
    int secondDecade = number %100;
    int result = secondDecade / 10;
    return result;
}

int middleNum = middleNumber(number);
Console.WriteLine($"cредняя цифра  {middleNum}.");