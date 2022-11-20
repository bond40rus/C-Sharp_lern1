//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//D = sqrt (Bx-Ax)^2+(By-Ay)^2+(Bz-Az)^2.

Console.WriteLine("Введите координату x точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки А: ");
int Az = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату x точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az,2)), 2);
Console.WriteLine(distance);
