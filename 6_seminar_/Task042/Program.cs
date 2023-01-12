//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();

string GetBinaryStr(int num)
{
    string binaryStr = string.Empty;
    while(num > 0)
    {
        binaryStr = Convert.ToString(num% 2) + binaryStr; //если поменять местами слагаемые в привычной строке присвоения значения, можно обойтись без функции разворота
        num /= 2;
    }
    return binaryStr;
}

int ReverseBinaryNum(string rtSyranib)
{
    string binaryStr = string.Empty;
    for (int i = 0; i < rtSyranib.Length; i++)
    {
        binaryStr += rtSyranib[rtSyranib.Length - i - 1];
    }
    int binaryNum = Convert.ToInt32(binaryStr);
    return binaryNum;
}

//Универсальный математический перевод из 10-ой системы в любую (до 16-ричной)
string DecToNum(int decadeNum, int otherSystem)
{
    string result = string.Empty;
    string systems = "0123456789ABCDEF";
    while (decadeNum > 0)
    {
        int remainder = decadeNum / otherSystem;
        result = systems[decadeNum - otherSystem * remainder] + result;
        decadeNum /= otherSystem;
    }
    return result;
}

Console.Write("Введите число: ");
int decadeNum = int.Parse(Console.ReadLine());
string binaryStr = GetBinaryStr(decadeNum);
Console.Write($"Число {decadeNum} в двоичной системе равно {binaryStr}.");
// int binaryNum = ReverseBinaryNum(binaryStr);
// Console.WriteLine($"Число {decadeNum} в двоичной системе равно {binaryNum}.");