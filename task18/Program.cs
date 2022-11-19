//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string [] quarters = {"x > 0; y > 0",// 0
                      "x < 0; y > 0",// 1
                      "x < 0; y < 0",// 2
                      "x > 0; y < 0"// 3
};
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if(quarter >= 1 && quarter <= 4)
{
    Console.WriteLine(quarters[quarter-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}
