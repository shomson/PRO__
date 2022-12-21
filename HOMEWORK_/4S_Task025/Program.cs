//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
Console.Clear();

// void DegreeA()
// {
//     Console.Write("Введите число A: ");
//     int A = int.Parse(Console.ReadLine());
//     Console.Write("Введите число B: ");
//     int B = int.Parse(Console.ReadLine());
    
//     double DegreeA = A;
//     for (int i = 1; i < B; i++)
//     {
//         DegreeA = DegreeA * A;
//     }
//     Console.WriteLine($"Число {A} в {B} равно {DegreeA}.");
// }

// DegreeA(); //не работает для B < 0, = 0 / A = 0 && B = 0

Console.Write("Введите число >1: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
if(N < 1)
    {
        i = N;
        N = 1;
    }

for( ; i <= N; i++)
    {
        Console.WriteLine($"{i} -> {Math.Pow(i, 3)}");
    }