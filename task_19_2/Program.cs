//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//на любое количество цифр!

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n;
int newNumber = 0, i = Convert.ToString(n).Length - 1;
while (i >= 0)
{
    newNumber = newNumber + (n % 10 * Convert.ToInt32(Math.Pow(10, i)));
    n = n / 10;
    i--;
}
Console.WriteLine(newNumber == result);