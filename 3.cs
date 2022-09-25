//Посчитать сумму цифр трехзначного числа(перевернуть число)

int n, a, b, c, x;
n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000)
{
    a = n % 10;
    n /= 10;
    b = n % 10;
    n /= 10;
    c = n % 10;
    x = a + b + c;
    Console.WriteLine($"сумма цифр трехзначного числа={x}");
    Console.WriteLine($"перевернутое число: {Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c)}");
}
else
    Console.WriteLine("введите трехзначное число" );
