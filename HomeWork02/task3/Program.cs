//ДЗ 3: определение выхлдной\будний дени с провверкой ввода менше 1го и больше 7ми
Console.Clear();
Console.Write("Введите день недели: ");
int x = int.Parse(Console.ReadLine()!);
Console.Clear();

if ((x <= 7) && (x > 0))
{
    if ((x > 0) && (x <= 5))
    {
        Console.WriteLine("будний день");
    }
    if ((x > 5) && (x <= 7))
        Console.WriteLine("выходной день");
}
else
{
    Console.WriteLine("не может быть меньше 1го или больше 7 дней в неделе!");
}