int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}
Console.Clear();
Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");