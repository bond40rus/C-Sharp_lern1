//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// Решил усложнить  задачку и теперь можно ввести любое число кроме числа с минусом можно было проверку написать на положительное число
// Хотел бы узнать ваше мнение, нормальный ли код?
Console.WriteLine("Введите число");
long num = Convert.ToInt64(Console.ReadLine());
string NumString = Convert.ToString(num);
int min = 0;
int max = NumString.Length-1;
string res = "Одна цифра";
while (min != max && (min < NumString.Length-1 || max > 0 )) // доп. проверка что бы не выходил за массив
{
    //Console.WriteLine($"index = {min} {max}  number = {NumString[min]} {NumString[max]}"); // для проверки ;)
    if (NumString[min] == NumString[max])
    {
        res = "Палиндром";
        min++;
        max--;        
    }
    else
    {
        res = "Не палиндром";
        break;
    }
}
Console.WriteLine($"{res}"); 
