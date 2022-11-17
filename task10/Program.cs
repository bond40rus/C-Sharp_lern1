// Напишите программу, которая прнимает на вход трехзначное число и на входе показывает вторую цифру этого числа.
// 456 -> 5


int rnd = new Random().Next(-999,1000);
Console.WriteLine(rnd); 
int res = Math.Abs((rnd / 10)%10);
Console.WriteLine(res); 