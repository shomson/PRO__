Console.Clear(); //очистка терминала
Console.Write("Введите число от 1 до 7: ");
int weekDayNumber = int.Parse(Console.ReadLine());

if(weekDayNumber <1 || 7< weekDayNumber) //проверка на некорректное число
{
    Console.WriteLine("Введено некорректное число!");
}
else
{
Console.Write($"{weekDayNumber} день недели, это - ");
if(weekDayNumber == 1) Console.WriteLine("понедельник");
if(weekDayNumber == 2) Console.WriteLine("вторник");
if(weekDayNumber == 3) Console.WriteLine("среда");
if(weekDayNumber == 4) Console.WriteLine("четверг");
if(weekDayNumber == 5) Console.WriteLine("пятница");
if(weekDayNumber == 6) Console.WriteLine("суббота");
if(weekDayNumber == 7) Console.WriteLine("воскресенье");
}

//решение через конструкцию switch/case
Console.Write("Введите число от 1 до 7: ");
string weekDayNumb = Console.ReadLine();
Console.Write($"{weekDayNumb} день недели, это - ");
switch (weekDayNumb)
{ 
     case "1":
    Console.WriteLine("понедельник");
    break;
     case "2":
    Console.WriteLine("вторник");
    break;
     case "3":
    Console.WriteLine("среда");
    break;
     case "4":
    Console.WriteLine("четверг");
    break;
     case "5":
    Console.WriteLine("пятница");
    break;
     case "6":
    Console.WriteLine("суббота");
    break;
     case "7":
    Console.WriteLine("воскресенье");
    break;   
}