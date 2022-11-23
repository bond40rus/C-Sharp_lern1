//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetNumberPow(int number, int rank)
{
    int res = 1, count ;
    for(count = 0; count < rank; count++)
    {
        res = number*res;
        //Console.WriteLine(res);
    } 
    return res;
}
Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень -> ");
int pow = Convert.ToInt32(Console.ReadLine());

int result = GetNumberPow(num,pow);
Console.WriteLine(result);