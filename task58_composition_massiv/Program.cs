// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

Console.Write("Введите размер двух масивов : ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int[,] matrix1 = FillMatrix(m, n);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = FillMatrix(m, n);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] resultMatrix = new int[m,n];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrix1[i,k] * matrix2[k,j];
        }
    resultMatrix[i,j] = sum ;
    Console.Write(resultMatrix[i,j] + " ");
    }
    Console.WriteLine();
}


