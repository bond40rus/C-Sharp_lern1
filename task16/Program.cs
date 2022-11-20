//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay,2)), 2);
Console.WriteLine(distance);
