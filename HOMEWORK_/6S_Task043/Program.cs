//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

string IntersectionCoor(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    string result = x.ToString() + "; " + y.ToString();
    return result;
}

Console.WriteLine("Две прямые задаются уравнением y = k * x + b");
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());

Console.Write($"Точка пересечения прямых -> ({IntersectionCoor(b1, k1, b2, k2)})");

//Решение преподавателя

// Clear();
// Write("Введите через пробел b1, k1, b2 , k2: ");
// string[] f = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// double b1 = double.Parse(f[0]);
// double k1 = double.Parse(f[1]);
// double b2 = double.Parse(f[2]);
// double k2 = double.Parse(f[3]);

// WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));




// double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
// {
//     double[] result = new double[2];
//     result[0] = (inB2 - inB1) / (inK1 - inK2);
//     result[1] = inK1 * result[0] + inB1;
//     return result;
// }