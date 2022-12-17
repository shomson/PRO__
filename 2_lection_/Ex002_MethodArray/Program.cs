int[] array = {1, 34, 56, 23, 67, 221, 568, 12, 23};

int n = array.Length; //Length - содержит информацию о длине массива (кол-ве чисел)
int find = 23;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //останавливает цикл при выполнении условия (при повторяющихся значениях чисел в массиве)
    }
    index++; //index = index + 1;
}