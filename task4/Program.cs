// Задача №4

List<int> numbers = new List<int>();
Console.WriteLine("Нахождение минимального и максимально числа в списке чисел ");
Console.Write("Сколько  чисел будем писать? => ");
int count = Convert.ToInt32(Console.ReadLine());
int i = 0;

Console.WriteLine("Какие это числа => ");
while (i < count)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
    i++;
}

int max = numbers[0];
int min = numbers[0];
foreach (var inti in numbers)
{
    if (inti > max){
        max = inti;
    }

    if (inti < min){
        min = inti;
    }
}

Console.WriteLine($"max = {max}, min = {min}");