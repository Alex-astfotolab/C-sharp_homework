int GetDegree(int a, int b)
{
    int res = 1;
    int i = 0;
    while( i < b)
    {
        res = res * a;
        i++;
    }
    return res;
}

Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine($"число {x} в степени {y}: {GetDegree(x, y)}");