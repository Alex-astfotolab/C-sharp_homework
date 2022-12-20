//ДЗ 2: нахождение третьего символа числа с проверкой на отсутствие третьего символа
Console.Clear();
int x = new Random().Next(1, 100000);

if(x > 99)
{
string num = x.ToString();

Console.WriteLine($"{x} -> {num[2]}");
}
else{
    Console.WriteLine($"{x} -> нет третьего знака!!!");
}
