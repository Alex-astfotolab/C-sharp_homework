int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] num = GetArray(10, -7, 999);
int tmp;
Console.Clear();
Console.WriteLine("исходный массив");
Console.WriteLine($"{String.Join(" ", num)}");
for (int i = 0; i < num.Length - 1; i++)
{
    for (int z = i + 1; z < num.Length; z++)
    {
        if (num[i] > num[z])
        {
            tmp = num[i];
            num[i] = num[z];
            num[z] = tmp;
        }
    }
}

Console.WriteLine("отсортированный массив");
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"{num[i]} ");
}