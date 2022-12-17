//Найти максимум из 9 чисел.
Console.Clear();

int MAX(int arg1, int arg2, int arg3) 
{ //тело метода
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//             0  1   2   3  4   5    6    7   8    //индексы чисел внутри массива
int[] array = {1, 34, 56, 3, 67, 221, 568, 12, 23}; //array - массив
//array[0] = 12; //таким образом можно присвоить индексу внутри массива другое значение
//Console.WriteLine(array[0]);

int max = MAX(
    MAX(array[0], array[1], array[2]), //используем числа внутри массива, вместо отдельных переменных
    MAX(array[3], array[4], array[5]), 
    MAX(array[6], array[7], array[8]));

Console.WriteLine(max);