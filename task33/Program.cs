//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив:"+ string.Join(" ",array));
bool check = false;
Console.Write("Введите искомое число ");
int a = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < array.Length; i++)
{
    if (array[i]==a){
        check=true;
    }
}

if (check==true)
{Console.Write("Массив содержит число");}
else {Console.Write("Массив НЕ содержит число");}
