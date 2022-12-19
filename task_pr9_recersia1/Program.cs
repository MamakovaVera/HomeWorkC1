/* задача найти сумму без сложения. через рекурсию*/


int sum(int n, int m)
{
if (m == 0)
return n;
return sum(n + 1, m - 1);
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n, m));