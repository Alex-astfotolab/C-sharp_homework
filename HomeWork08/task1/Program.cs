Console.Clear();
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите диапазон: от 1 до ");
int range = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
GetArray(array);
PrintArray(array);

Console.WriteLine($"Отсортированный массив: ");
SumArrayLines(array);
PrintArray(array);


void SumArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,range);
    }
  }
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
}


