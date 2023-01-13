int GetSum(int x)
    {
        int sum = 0;
        while(x > 0)
        {
            sum += x % 10;
            x /= 10;
        }
        return sum;
    }

Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Сумма знаков числа {x}: {GetSum(x)}");