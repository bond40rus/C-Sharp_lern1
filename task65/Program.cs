// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Rec(int n, int m)
{
    if (m > n)
    {
        if (n == m)
        {
            return;
        }
        Rec(n, m - 1);
        Console.Write($"{m} ");
    }
    else if (m < n)
    {
        if (m == n) return;
        Rec(n - 1, m);
        Console.Write($"{n} ");
    }
    else Console.Write($"{m} ");
}
Console.Write("Введите первое значение: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите второй значение: ");
int M = int.Parse(Console.ReadLine());
Rec(N, M);

