// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2 


int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите сколько будет строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сколько будет столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int maxn = 0;
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(0) - 1; j++)
    {
        maxn = j;
        for (int k = j + 1 ; k < matrix.GetLength(0); k++)
        {
            if (matrix[i, k] > matrix[i, j])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }
            maxn = k;
        }
    }
}

PrintMatrix(matrix);

