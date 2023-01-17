int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int resault(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if(el > 0 && el > 100 && el % 2 == 0)
        {
            count++;
        }
        
    } 
    return count;
}
Console.Clear();
int[] array = GetArray(6, 1, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"из них четных: {resault(array)}");