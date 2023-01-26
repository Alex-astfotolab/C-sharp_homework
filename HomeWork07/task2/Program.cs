int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(1, 99);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите число столбцов: ");
int colums = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите искомое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] array = GetArray(rows, colums);
PrintArray(array);

bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i, j] == x)
                    {
                        flag = true;
                        Console.WriteLine($"число {x} найдено");
                    }
                }
            }
