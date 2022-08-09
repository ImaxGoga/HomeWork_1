Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int Max = a;
if (Max < b)
{
    Max = b;
}
if (Max < c)
{
    Max = c;
}
Console.Write("Максимальное число: ");
Console.Write(Max);