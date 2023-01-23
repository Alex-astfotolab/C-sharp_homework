Console.Clear();
Console.Write("Введите любые числа, через пробел: ");
Console.Clear();
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}


Console.WriteLine($"чисел больше 0: {count}");
