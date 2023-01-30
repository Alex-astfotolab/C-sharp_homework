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

int minSum = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumLineElements(array, i);
  if (sumLine > tempSum)
  {
    sumLine = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}