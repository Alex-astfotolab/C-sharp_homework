void GetArrey(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.Clear();
Console.WriteLine("введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Clear();
double[,] numbers = new double[lines, columns];
GetArrey(numbers);
PrintArray(numbers);