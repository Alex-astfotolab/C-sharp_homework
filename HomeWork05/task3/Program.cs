int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetSumEl(int[] array)
{
    int x = array[0] * array[3];
    int y = array[1] * array[2];
    
    

}

int[] array = GetArray(4, 1, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"{GetSumEl(array)}");