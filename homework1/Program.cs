// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 1;
int Reverse (int N, int x)
{
    if (N == x) return N;
    Console.Write($"{Reverse(N, x + 1)}, ");
    return x;
}

Reverse(N, x);
System.Console.Write(1);
System.Console.WriteLine();