﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int rows, int columns, int shir)
{
    int[,,] matrix = new int [rows, columns, shir];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(0,100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      //Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"{matrix[i,j,k]}({i},{j},{k})  ");
      }
      Console.WriteLine();
    }
    //Console.WriteLine();
  }
}

Console.Write("Введите размер X : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер Y : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер Z : ");
int k = Convert.ToInt32(Console.ReadLine());

int [,,] matrix = FillMatrix(m,n,k);
PrintMatrix(matrix);
Console.WriteLine();