//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
Console.Clear();

Console.Write("Введите 5-ти значное число: ");
string N = Console.ReadLine();

// void Polindrom(string text)
// {
//     while(text.Length != 5)
//        {
//            Console.Write("Некорректное число! Попробуйте снова: ");
//            text = Console.ReadLine();
//        }
    
//     int length = text.Length;
//     int i = 0;
//     for( ; i < (length - 1) / 2; i++)
//         {
//             if(text[i] == text[length - 1 - i])
//             {
//                 continue;
//             }
//             else
//             {
//                 Console.Write($"{text} -> НЕ полиндром.");
//                 break;
//             }
//         }
//     if(i >= length / 2) Console.WriteLine($"{text} -> полиндром."); //признак, что цикл for завершился
// }

// Polindrom(N);

while(N.Length != 5)
   {
        Console.Write("Некорректное число! Попробуйте снова: ");
        N = Console.ReadLine();
   }

if(N[0] == N[4] && N[1] == N[3])
{
    Console.Write($"{N} -> полиндром.");
}
else
{
    Console.Write($"{N} -> НЕ полиндром.");
}


