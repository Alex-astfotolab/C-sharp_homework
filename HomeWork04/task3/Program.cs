int[] GetArrey(int n)
{
    int[] NumArrey = new int[n];
    for(int i =0; i < n; i++)
    {
        NumArrey[i] = new Random().Next(-1000,1000);
    }
    return NumArrey;
}

int[] x = GetArrey(8);
Console.WriteLine($"[{String.Join("|", x)}]");
