// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите значение N");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
void Chisla(int n)
{
    if (n==0) return;
    Chisla(n-1);
    Console.Write(n+" ");
}
    Chisla(N);
