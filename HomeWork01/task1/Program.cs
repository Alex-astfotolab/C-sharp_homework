//ДЗ Задача 1: найти меньшее из двух чисел.
Console.Write("Вычисление меньшего из двух чисел");
Thread.Sleep(1500);
Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.Clear();
int min = 0;

if(x < y){
    min = x;
    Console.WriteLine($"Минимальное число: {min}");
}
else if(x > y){
    min = y;
    Console.WriteLine($"Минимальное число: {min}");
}
