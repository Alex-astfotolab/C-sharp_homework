int SequenceNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{SequenceNumber(n, m + 1)}, ");
    return m;
}

Console.Clear();
Console.Write("Введите положительное число: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.Clear();

if (n < 1)
{
    Console.WriteLine("не положительное число");
}
Console.WriteLine(SequenceNumber(n, m));