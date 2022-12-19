//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
Console.Clear();

int number = new Random().Next(1, 100000);
//int number = 123;
Console.WriteLine($"Число {number}.");

int index = 0;

while(number != number %Convert.ToInt32(Math.Pow(10, index)))
{
    index++;
} //после выхода из цикла index показывает разрядность числа
 
//Console.WriteLine($"index {index}");
if(index >= 3)
{
    int NUM = number / Convert.ToInt32(Math.Pow(10, index - 3)); //в параметре [-3] задается цифра которая вам нужна
    int remainder = NUM %10;
    Console.WriteLine($"Его третья цифра -> {remainder}.");
}
else
{
    Console.WriteLine("Третьей цифры не сущетсвует.");
}