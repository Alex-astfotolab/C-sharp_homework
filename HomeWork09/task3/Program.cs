
int FAkk(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FAkk(m - 1, 1);
    else
        return FAkk(m - 1, FAkk(m, n - 1));
}
Console.Clear();
Console.WriteLine("Введите два положительных числа: M и N.");
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Clear();

Console.WriteLine($"A({m}, {n}) = {FAkk(m, n)}");