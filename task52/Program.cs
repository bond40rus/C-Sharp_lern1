// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Поиск средних арифметических каждого столбаца из массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

double sum = 0;

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

Console.WriteLine();
Console.WriteLine("Итог");

for (int k = 0; k < n; k++)
{
    for (int l = 0;l < m; l++)
    {
        sum = matrix[l,k] + sum;
    }
    double agr = Convert.ToDouble(string.Format("{0: .0}" , sum / m ));
    Console.Write(agr + "\t");
    sum = 0;
}
