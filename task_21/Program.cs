Console.Clear();
Console.Write("Ведите координату A1: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату A2: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2) + Math.Pow(z1 - z2, 2)));
