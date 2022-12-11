// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Rec(int start, int end, int sum)
{
    if (start > end) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (start++);
    Rec(start, end, sum);
}


Console.Write("Введите первое значение: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй значение: ");
int M = Convert.ToInt32(Console.ReadLine());
Rec(N, M, 0);
