Console.Clear();
Console.Write("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;
if(numberB > max)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}
Console.Write($"Максимаоьное число: {max}");
