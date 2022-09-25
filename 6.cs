// Високосный ли год? Сколько високосных годов в указанном отрезке?
int a, b, a1, b1;
Console.WriteLine("Введите два года");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
a1 = 0;
b1 = 0;
if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
{
    Console.WriteLine($"{a} - високосный год");
    a1 = 1;
}
else
    Console.WriteLine($"{a} - НЕ високосный год");
if ((b % 4 == 0 && b % 100 != 0) || (b % 400 == 0))
{
    Console.WriteLine($"{b} - високосный год");
    b1 = 1;
}
else
    Console.WriteLine($"{b} - НЕ високосный год");
if (a1 == 1 && b1 == 1)
{
    Console.WriteLine($"{(Math.Abs(b - a) / 4) + 1}-количество високосных годов в период с {a} по {b}");
}
else
{
    Console.WriteLine($"{(Math.Abs(b - a) / 4) + b1 + a1}-количество високосных годов в период с {a} по {b}");