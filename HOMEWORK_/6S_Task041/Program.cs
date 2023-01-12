//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int FindPositiveNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count += 1;
    }
    return count;
}

Console.Write("Введите числа через пробел: ");
string numbers = Console.ReadLine();
int[] array = GetArrayFromString(numbers);
// Console.WriteLine(String.Join(" ", array));
Console.Write($"Кол-во чисел больше нуля - {FindPositiveNums(array)}.");
