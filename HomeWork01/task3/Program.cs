//ДЗ Задача 3:Провека числа на четность.
Console.Write("Проверка числа на четность");
Thread.Sleep(1500);
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();

if(x % 2 == 0){
    Console.WriteLine($"число: {x}, четное ");  
}
else{
    Console.Write($"число: {x}, не четное ");
} 