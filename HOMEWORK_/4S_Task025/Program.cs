//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
Console.Clear();

void DegreeA()
{
    Console.Write("Введите число A: ");
    double A = int.Parse(Console.ReadLine());
    Console.Write("Введите число B: ");
    int B = int.Parse(Console.ReadLine());
    
    if(B == 0) Console.WriteLine($"Число {A} в степени {B} равно 1.");
    
    if(B > 0)
    {
        if(A != 0)
        {
            double DegreeA = A;

            for (int i = 1; i < B; i++)
            {
                DegreeA = DegreeA * A;
            }
            Console.WriteLine($"Число {A} в степени {B} равно {DegreeA}.");
        }
        else Console.WriteLine($"Число {A} в степени {B} равно 0.");
    }

    if(B < 0)
    {   
        if(A == 0) Console.WriteLine($"Число {A} в степени {B} равно ∞.");
        if(A == 1) Console.WriteLine($"Число {A} в степени {B} равно 1.");
        if(A != 0 && A != 1)
        {
            Console.Write($"Число {A} в степени {B} равно ");
            A = (1 / A);
            B = B * -1;
            double DegreeA = A;

            for (int i = 1; i < B; i++)
            {
                DegreeA = DegreeA * A;
            }
            Console.WriteLine($"{Math.Round(DegreeA, 5)}.");
        }
    }
}

DegreeA();