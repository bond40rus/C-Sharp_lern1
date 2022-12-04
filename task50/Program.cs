// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


Console.WriteLine("Поиск в массиве");
Console.Write("Поиск по строке = ");
int findx = Convert.ToInt32(Console.ReadLine())-1; // -1  удобно для пользователя :)

Console.Write("Поиск по столбику = ");
int findy = Convert.ToInt32(Console.ReadLine())-1;

int m = new Random().Next(2,11); //Convert.ToInt32(Console.ReadLine());
int n = new Random().Next(2,11); //Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"в Массиве");
int [,] matrix = new int [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

try // решил воспользоватся обработкой ошибок / исключений, разумно ли?
{
    Console.WriteLine();
    Console.Write($"Нашлось число = {matrix[findx,findy]}");
}
catch
{
    Console.Write($"Такого елемента нет");
}