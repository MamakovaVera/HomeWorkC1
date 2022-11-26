Console.Write("Введите 1е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число: ");
int c = Convert.ToInt32(Console.ReadLine());

int maxNumbers = a;
if (maxNumbers < b)
    maxNumbers = b;
if (maxNumbers < c)
    maxNumbers = c;

Console.Write(maxNumbers);
