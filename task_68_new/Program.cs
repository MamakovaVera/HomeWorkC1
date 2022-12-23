/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Acc(int M, int N) {
    if (M == 0) {
        return N + 1;
    }
    else if (N == 0 && M > 0) {
        return Acc(M - 1, 1);
    }
    else {
        return Acc(M - 1, Acc(M, N - 1));
    }
}
Console.WriteLine(Acc(m, n));
