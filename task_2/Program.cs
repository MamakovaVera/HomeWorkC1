Console.Clear();

Console.Write("Введите 1е число, ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2е число, ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > b) max = a;
if (a < b) max = b;
Console.Write("max = ");
Console.WriteLine(max);





