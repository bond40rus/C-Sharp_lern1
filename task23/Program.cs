﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int GetSquare (int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result = i*i*i;
        Console.WriteLine(result);
    }
    return result;
}
Console.Write("Введите число -> ");
int UserNum = Convert.ToInt32(Console.ReadLine());
int res = GetSquare(UserNum);
