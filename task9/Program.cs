// Напишие программу, которая выводит случайное число из отрезка [10, 99] и  ип оказывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {number}");
int dij1 = number / 10;
int dij2 = number % 10;

if (dij1 == dij2)
{
    Console.WriteLine("Удача, два числа равны");
}
else
{
    if (dij1 > dij2)
    {
        Console.WriteLine($"Наибольшее число {dij1}");
    }
    else
    {
        Console.WriteLine($"Наибольшее число {dij2}");
    }
}