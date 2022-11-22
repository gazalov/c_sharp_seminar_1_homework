Console.Clear();
Console.Write("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA>numberB)
{
Console.Write("Первое число больше второго.");
}
else
{
Console.Write("Второе число больше первого.");
}
