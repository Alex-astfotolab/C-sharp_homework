Console.Clear();
Console.WriteLine("Поиск всех четных чисел в диапазоне от 1 до N ");
Thread.Sleep(1500);
Console.Clear();
Console.WriteLine("Введи число: ");
int usernum = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("последовательность четных чисел: ");
int num = 0;

while(num <= usernum)
{
    if(num % 2 == 0){
    Console.WriteLine(num);
    num++;
} 
    else{
    num++;
    }
}