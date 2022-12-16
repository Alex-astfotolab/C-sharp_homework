//ДЗ Задача 2: найти большее из 3х чисел.
Console.Write("Вычисление большего из трех чисел");
Thread.Sleep(1500);
Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Введите третье число: ");
int z = int.Parse(Console.ReadLine()!);
Console.Clear();
int max = 0;

if(x > y && x > z){
    max = x;
    Console.WriteLine($"Максимальное число: {max}");
}
else if(y > x && y > z){
    max = y;
    Console.WriteLine($"Максимальное число: {max}");
}
else if(z > y && z > x){
    max = z;
    Console.WriteLine($"Максимальное число: {max}");
}
