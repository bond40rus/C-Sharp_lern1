// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int rnd = new Random().Next(-999,1000);
Console.WriteLine(rnd); 
int res = Math.Abs((rnd / 10)%10);
Console.WriteLine(res); 