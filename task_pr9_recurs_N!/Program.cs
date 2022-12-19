// нахождение факториала числа N, через рекурсию

int sum(int n)
{
    Console.WriteLine($"{n} ");
    if (n == 0)
    return 1;
    return sum(n - 1) * n;
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n));