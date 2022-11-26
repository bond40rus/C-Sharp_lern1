//Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(string.Format("{0: .00}" , new Random().Next(10,100)))/*+0.01*/; //не хочет показывать цифры после запятой, но цифры  double  если  например +0.01
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(num);
Console.WriteLine("Ваш массив: ["+ string.Join(", ",array) +"]");

double mini = array[0];
double maxi = array[0];

for(int i = 0 ; i < array.Length; i++)
{
    if(mini > array[i] )
    {
        mini = array[i];
    }

    if(maxi < array[i] )
    {
        maxi = array[i];
    }
}
double diff = maxi - mini;
Console.Write($"min = {mini} max = {maxi} diff = {diff}");

