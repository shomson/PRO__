//Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();

int number = new Random().Next(100, 1000);
Console.WriteLine($"Число {number}.");

int middleSniper(int number)
{
    int firstDecade = number %10;
    int thirdDecade = number / 100;
    int result = thirdDecade * 10 + firstDecade;
    return result;
}

int split = middleSniper(number);
Console.WriteLine($"Новое число {split}.");

//группа сделала хитрее: Console.WriteLine($"{number} -> {thirdDecade}{firstDecade}");