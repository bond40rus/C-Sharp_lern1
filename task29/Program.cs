//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Сколько чисел будет в массиве? -> ");
int count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите цифры от 1 до {count}");
//int num = Convert.ToInt32(Console.ReadLine());


int[] UserArr = new int[count];
int[] RndArr = new int[count];

for(int i = 0 ;i < count; i++)
{
    UserArr[i] = Convert.ToInt32(Console.ReadLine());
    RndArr[i] = new Random().Next(1,count+1); // было бы здорово если бы не повторялись, но это совсем другая история :)

}
Console.Write("Ваши цифры " + '[' + string.Join(", ", UserArr) + ']');
Console.WriteLine("");
Console.Write("Выпавшие цифры " + '[' + string.Join(", ", RndArr) + ']');
Console.WriteLine("");
if (UserArr.SequenceEqual(RndArr)) //погуглил чтоб сравнить два массива
{
    Console.WriteLine("Вы выиграли!");
}
else
{
    Console.WriteLine("Проиграли");
}