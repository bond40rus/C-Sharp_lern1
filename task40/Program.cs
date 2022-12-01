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
Console.WriteLine(string.Join(", ", array));

int[] newArray = new int[num];
for(int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i];
}
Console.WriteLine(string.Join(", ", newArray));
