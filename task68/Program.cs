// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите начальное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

///Метод вычисления функции Аккермана:
int RecAckermann (int numM, int numN)
{
    if (numM == 0) 
    {
        return numN + 1;
    }
    else
    {
        if (numM != 0 && numN == 0) 
        {
            return RecAckermann(numM - 1, 1);
        }
        else
        {
            if (numM > 0 && numN > 0) 
            {
            return RecAckermann(numM - 1, RecAckermann(numM, numN - 1));
            }
        } 
    }
return RecAckermann(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {RecAckermann(numM, numN)}");

