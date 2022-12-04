// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (i %2 == 0 && j %2 == 0) { matrix[i,j] = Math.Pow(new Random().Next(0,11),2); }
        else {matrix[i,j] = new Random().Next(0,11);}
        
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
