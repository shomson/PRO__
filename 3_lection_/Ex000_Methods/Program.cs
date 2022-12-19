//Вид 1, НЕ принимает и НЕ возвращает данные
void Method1()
{
    Console.WriteLine("Автор: Шамиль Фаттахов");
}
Method1(); //вызов метода, обязательно с ()




//Вид 2, принимает и НЕ возвращает данные
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения: "); //отображение в консоли сообщения
//Method2(msg: "Текст сообщения: "); //[msg:] - здесь используется именованный аргумент

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст сообщения: ", 4);
Method21(count: 4, msg: "Текст сообщения: "); // именованные аргументы необязательно могут находиться по порядку

//Вид 3, НЕ принимает и возвращает данные
int Method3() //необходимо выбрать тип данных для метода
{
    return DateTime.Now.Year;
}
int year = Method3(); //создать переменную, чтобы присвоить ей результат работы метода
Console.WriteLine(year);



//Вид 4, принимает и возвращает данные

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++) //for(условная переменная; условие; счетчик)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, ".вагон.");
Console.WriteLine(res);