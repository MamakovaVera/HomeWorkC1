//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int x = new Random().Next(100, 1000); // [100, 999]
        while (array.Contains(x))
            x = new Random().Next(100, 1000); // [100, 999]
        array[i] = x;
    }
}


int ReleaseArray(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven++;
    }
    return countEven;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Наальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");
