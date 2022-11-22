System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//It is impossible to use divider in noninteger numbers as "," so decided to chanche localisation to en-US to use "."
Console.Clear();
Console.Write("Введите целое положительное число: ");

int numberA = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine($"Вывожу положительные числа от 1 до {numberA}:");
while(i<=numberA)
{
    if(i % 2 == 0) 
    {
    Console.WriteLine(i);
    }
i++;
}
