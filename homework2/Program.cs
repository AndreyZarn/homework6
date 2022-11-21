// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (n<m)
{ temp = n; n = m; m = temp;
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");}
else 
{
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");
}
int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}
System.Console.WriteLine();