﻿// Нвапишите программу, которая принмиает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 нет
// 46 нет
// 161 да

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 %23 == 0)
{
    Console.WriteLine("Число кратно7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
