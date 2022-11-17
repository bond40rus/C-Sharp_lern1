// Напишите програму, которая будет принмать на вход два числа и выводить, является ли второе число кратным первому.
// если число 2 не кратно 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите превое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mod = num1 % num2;
if (mod == 0){
    Console.WriteLine("Числа кратные");
}
else{
    Console.WriteLine($"Числа не кратные остатков {mod}");
}