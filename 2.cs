//Выведите max из 3 чисел
double a, b, c, mx;
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
mx = a;
if (b > mx)
    mx = b;
if (c > mx)
    mx = c;
Console.WriteLine($"максимальное число = {mx}" );
