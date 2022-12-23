//ДЗ задача1: нахождение 2ой цифры трехзначного числа с проверкой ввода на >< 3х знаков
Console.Clear();
Console.Write("Введите трехзначтное число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();

if((x > 99) && (x < 1000))
{
string num = x.ToString();

Console.WriteLine($"второй знак числа {x}, {num[1]}");
}
else{
    Console.WriteLine($"число {x} не трехзначное!!!");
}