//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

void weekDayOrEnd(int weekDayNum)
{
    while(weekDayNum <1 || 7< weekDayNum)
       {
           Console.Write("Некорректная цифра! Попробуйте снова: ");
           weekDayNum = int.Parse(Console.ReadLine());
       }
    
    if(weekDayNum == 6 || weekDayNum == 7)
       {
           Console.Write($"{weekDayNum}-й это выходной.");
       }
    else
       {
           Console.Write($"{weekDayNum}-й это будний день.");
       }
}

Console.Write("Введите цифру дня недели: ");
int weekDayNum = int.Parse(Console.ReadLine());
weekDayOrEnd(weekDayNum);