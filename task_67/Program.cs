﻿/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
int rec(int n) //решение через рекурсию (!если через метод, то есть решение в 27 задаче)
{
if (n % 10 == n || n < 10 || n / 10 == 0)
return n;
return rec(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));