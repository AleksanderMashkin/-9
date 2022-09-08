/* 
Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
{
int max = 0;
int min = 0;

if (M > N)
{
    max = M;
    min = N;
}
else
{
    max = N;
    min = M;
}
int number = 0;

for (int i = min; i <= max; i++)
{
    number = i;
    Console.WriteLine(number);
}
}
*/

/*
Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
{
int max = 0;
int min = 0;

if (M > N)
{
    max = M;
    min = N;
}
else
{
    max = N;
    min = M;
}
int sum = 0;

for (int i = min; i <= max; i++)
{
    sum = sum + i;
    }
    Console.WriteLine(sum);
}
*/

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}