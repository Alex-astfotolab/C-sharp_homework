//ДЗ задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();

for(int i = 1; i <= x; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}