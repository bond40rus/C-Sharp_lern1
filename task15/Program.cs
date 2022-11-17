Console.WriteLine("Введите число о 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 7)
{
    Console.WriteLine("Надо число от 1 до 7 попробуй еще раз");
    num = Convert.ToInt32(Console.ReadLine());
}
if (num >0 && num <6)
{
    Console.WriteLine("Не выходной, работаем");
}
else 
{
    Console.WriteLine("Выходной,  выдыхаем");
}
