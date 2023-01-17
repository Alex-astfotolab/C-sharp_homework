int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSum(int[] array)
{
    int resault = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            resault = resault + array[i];
        }
    }
    return resault;
}

int[] array = GetArray(4, -500, 500);
Console.Clear();
Console.WriteLine($"[{String.Join(".", array)}]");
Console.WriteLine($"Сумма элементов нечетных индексов массива: {GetSum(array)}");