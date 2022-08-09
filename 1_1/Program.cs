Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if ( a == b)
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" равно числу ");
    Console.Write(b);
}
else {
    if ( a > b)
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" больше чем число ");
    Console.Write(b);
}
else 
{
    Console.Write("Число ");
    Console.Write(b);
    Console.Write(" больше чем число ");
    Console.Write(a);
    
}
}

