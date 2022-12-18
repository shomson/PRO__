//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
Console.Clear();

//int number = new Random().Next(1, 100000);
int number = 123;
Console.WriteLine($"Число {number}.");

int index = 1;
int count = -1;

while(number != number %index)
{
    index = index * 10;
    count++;
}

Console.WriteLine($"{index} / {count}");
if(count > 1)
{
    int NUM = number / Convert.ToInt32(Math.Pow(10, count - 2));
    int remainder = NUM %10;
    Console.WriteLine($"Его третья цифра -> {remainder}.");
}
else
{
    Console.WriteLine("Третьей цифры не сущетсвует.");
}