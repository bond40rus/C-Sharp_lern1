int number = new Random().Next(99,1000);
Console.WriteLine(number);
int num = (number/100)*10;
int num2 = number%10;
Console.WriteLine(num+num2);