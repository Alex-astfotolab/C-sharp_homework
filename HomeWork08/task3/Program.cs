Console.Clear();
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите число столбцов 1-й матрицы и строк 2-й: ");
int n = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите диапазон: от 1 до ");
int range = int.Parse(Console.ReadLine()!);

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, x];
GetArray(secomdMartrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,x];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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