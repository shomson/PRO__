//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();

Console.Write("Введите номер четверти на плоскости: ");
int quarter = int.Parse(Console.ReadLine());

if(quarter == 1) Console.WriteLine("Возможные координаты x > 0, y > 0.");
if(quarter == 4) Console.WriteLine("Возможные координаты x > 0, y < 0.");
if(quarter == 2) Console.WriteLine("Возможные координаты x < 0, y > 0.");
if(quarter == 3) Console.WriteLine("Возможные координаты x < 0, y < 0.");

//возможное решение через команду switch[case|default]

switch(quarter)
{
   case 1:
   {
       Console.WriteLine("Возможные координаты x > 0, y > 0.");
       break;
   }
   case 2:
   {
       Console.WriteLine("Возможные координаты x < 0, y > 0.");
       break;
   }
   case 3:
   {
       Console.WriteLine("Возможные координаты x < 0, y < 0.");
       break;
   }
   case 4:
   {
       Console.WriteLine("Возможные координаты x > 0, y < 0.");
       break;
   }
   default:
   {
       Console.WriteLine("Введена некорректная четверть.");
       break;
   }
}
   
