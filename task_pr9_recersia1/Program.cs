/* задача найти сумму без сложения. через рекурсию*/


int sum(int n, int m)
{
    Console.WriteLine($"{n} {m}");
    if (m == 0)
    return n;
    return sum(n + 1, m - 1);
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n, m));

/*int sum()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
    return 0;
    return sum() + x;
}

Console.Clear();
Console.WriteLine(sum());
*/