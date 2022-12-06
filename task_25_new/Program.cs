//Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите 1е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int count = 1; count <= b; count++ )
{
   result = result * a;
}

Console.Write(result);
