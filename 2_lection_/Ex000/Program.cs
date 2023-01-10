//Найти максимум из 9 чисел.
Console.Clear();

//ниже описан вариант решения с помощью Функции (С# - метода)
int MAX(int arg1, int arg2, int arg3) 
{ //тело метода
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 3335;
int b1 = 22;
int c1 = 2;
int a2 = 317;
int b2 = 29;
int c2 = 41;
int a3 = 9;
int b3 = 12;
int c3 = 221;

//int max1 = MAX(a1, b1, c1);
//int max2 = MAX(a2, b2, c2);
//int max3 = MAX(a3, b3, c3);
//int max = MAX(max1, max2, max3);

int max = MAX( //отсылка к "функциоальному" программированию
    MAX(a1, b1, c1), 
    MAX(a2, b2, c2), 
    MAX(a3, b3, c3));

//внизу описан "стихийный" вариант решения
//int max = a1;
//if(b1 > max) max = b1;
//if(c1 > max) max = c1;

//if(a2 > max) max = a2;
//if(b2 > max) max = b2;
//if(c2 > max) max = c2;

//if(a3 > max) max = a3;
//if(b3 > max) max = b3;
//if(c3 > max) max = c3;

Console.WriteLine(max);