//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int CountNumber(int num)
{
int count = 0;
 for (count = 0; num != 0; count++)
    {
        num /=10;
     }
return count;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = CountNumber(num);
Console.WriteLine(result);
