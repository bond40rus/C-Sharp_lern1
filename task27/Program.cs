//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Сумма чисел рандомного числа -> ");
//string? num = Console.ReadLine();
string num = Convert.ToString(new Random().Next(-10000,10000));
int NumInt = Convert.ToInt32(num);
Console.Write(num);

int res =  0;
int start = 0;
if (NumInt < 0)
{
    res = 0 - (num[1]-48);
    //Console.WriteLine($" Новый рес -> {res}");
    start = 2;
}
for(int i = start; i < num.Length; i++)
{
    res = (num[i]-48) + res; 
    // эммм почему то когда когда беру число num[0]  и плюсую 0  то возвращает   от 48 до 59, наверно дело в конвертации символа в число но я нашел закономерность и минусовал это
    //Console.WriteLine($" будет равна -> {res}");
}
Console.Write($" будет равна -> {res}");


