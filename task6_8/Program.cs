//Задача №6  и №8
Console.Write("Введите число => ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2  == 0 ){
    Console.WriteLine($"Число {number} четное");
}
else{
    Console.WriteLine($"Число {number}  не четное");
}


int count = 2;
if (number > 1){
    while (count <= number){
        Console.Write(count + " ");
        count += 2;
    }
}
else{
    Console.WriteLine("нет чисел");
}