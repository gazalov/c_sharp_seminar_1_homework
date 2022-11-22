System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//It is impossible to use divider in noninteger numbers as "," so decided to chanche localisation to en-US to use "."
Console.Clear();
Console.Write("Введите число: ");

double numberA = double.Parse(Console.ReadLine());
double numberB = numberA % 2;
if(numberA % 2 == 0) 
{
    Console.WriteLine($"Число {numberA} является четным числом.");
}
else {
    Console.WriteLine($"Число {numberA} является нечетным числом.");
}