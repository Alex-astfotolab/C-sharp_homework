//ДЗ задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Проверка пятизначного числа, палиндром оно или нет");
Thread.Sleep(1500);
Console.Clear();
Console.Write("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();
string num = x.ToString();

if (num.Length < 5 )
{
    Console.Write($"не пятизначное число");
}
else if(num[0] == num[4] && num[1] == num[3])
{
    Console.Write($"число {x}: палиндром");
}
else
{
    Console.Write($"число {x}: не палиндром");
}