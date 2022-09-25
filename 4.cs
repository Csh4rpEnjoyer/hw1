// Решите квадратное уравнение
double a, b, c, D, x1, x2;
Console.WriteLine("Введите коээфициенты a b c из ax^2+bx+c");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
D = b * b - 4 * a * c;
if (D >= 0)
{
    x1 = (b + Math.Sqrt(D)) / -2 * a;
    x2 = (b - Math.Sqrt(D)) / -2 * a;

    Console.WriteLine($"x1={x1}");
    Console.WriteLine($"x2={x2}");
}
else
    Console.WriteLine("не имеет решений" );