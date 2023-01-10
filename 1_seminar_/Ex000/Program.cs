Console.Clear(); //очистка терминала
Console.Write("Введите число: ");

int numberA = int.Parse(Console.ReadLine()); //Parse - перевод введенных данных в число

//Решение математическим путем
int sqrMath = numberA * numberA;
Console.WriteLine($"Квадрат числа {numberA} равен = {sqrMath}"); //для добавление в текст переменных необходимо перед "" поставить знак $, затем в {} указать название переменной

//Решение с использованием библиотеки Math
int sqrLibr = Convert.ToInt32(Math.Pow(numberA, 2)); //Convert - конвертация типа данных перменной в ToInt32 [тип данных int], Pow - функция библиотеки Math для возведения (переменной, в степень)
Console.WriteLine($"Квадрат числа {numberA} равен = {sqrLibr}");

//пример для вещественных чисел без использования функции Convert
double numberB = 3.3;
double sqrEx = (Math.Pow(numberB, 2));
Console.WriteLine($"Квадрат числа {numberB} равен = {Math.Round(sqrEx, 2)}"); //Round - функция библиотеки для фиксации (у переменной, кол-ва чисел после запятой)