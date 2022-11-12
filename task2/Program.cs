// Задача №2 
Console.WriteLine("Нахождение min max  из двух чисел");

Console.Write("Введите  число А ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  число B ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA == numB){
    Console.WriteLine($"A и B Равны");}
else if (numA > numB) {
    Console.WriteLine($"A max = {numA}, B min = {numB}");
    }
    else{
        Console.WriteLine($"B max = {numB}, A min = {numA}");
    }
