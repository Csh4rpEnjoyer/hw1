//Даны 3 числа: есть ли среди них отриц.? есть ли среди них одно отриц.? все ли они отрицательные?
double a, b, c, a1, b1, c1;
string ans1, ans2, ans3;
Console.WriteLine("введите три числа");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
if (a < 0)
    a1 = 1;
else
    a1 = 0;
if (b < 0)
    b1 = 1;
else
    b1 = 0;
if (c < 0)
    c1 = 1;
else
    c1 = 0;
if (a1 + b1 + c1 > 0)
    ans1 = "да";
else
    ans1 = "нет";
if (a1 + b1 + c1 == 3)
    ans2 = "да";
else
    ans2 = "нет";
if (a1 + b1 + c1 == 1)
    ans3 = "да";
else
    ans3 = "нет";
Console.WriteLine($"есть ли среди них отрицательные числа? {ans1}" );
Console.WriteLine($"все ли они отрицательные? {ans2}");
Console.WriteLine($"среди них только одно отрицательное? {ans3}");