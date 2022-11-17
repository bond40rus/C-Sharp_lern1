// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 - > третьей цифры нет 
string rnd = Convert.ToString(new Random().Next(-100, 100));
Console.WriteLine($"Вам выпало число {rnd}");
int NumberRnd = Convert.ToInt32(rnd); //  так как операторы сравнения не действуют на строки....  и пригодится для цикла while
Console.Write($"Решение через String ");
if (NumberRnd > 0)
{
    if (rnd.Length < 3)
    {
        Console.WriteLine($"Нет третьей цифры у числа {rnd}");
    }
    else
    {
        Console.WriteLine($"Третье число = {rnd[2]}");
    }
}
else
{
    if (rnd.Length < 4)
    {
        Console.WriteLine($"Нет третьей цифры у числа {rnd}");
    }
    else
    {
        Console.WriteLine($"Третье число = {rnd[3]}");
    }
}
Console.Write($"Решение через while  ");
if (NumberRnd < 100 && NumberRnd > -100)
{
    Console.WriteLine($"Нет третьей цифры у числа {rnd}");
}
else
{
    while (NumberRnd > 99 || NumberRnd < -100)
    {
        if ((NumberRnd > 99 & NumberRnd < 1000) || (NumberRnd < -99 && NumberRnd > -1000))
        {
            Console.WriteLine($"Третье число = {Math.Abs(NumberRnd) % 10}");
            break;
        }
        else
        {
            NumberRnd = NumberRnd / 10;

        }
    }
}