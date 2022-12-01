// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3 


int[] FillArray(int size)
{    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());//
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]> 0 ) { count++;}
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Положительных чисел = {count}");

