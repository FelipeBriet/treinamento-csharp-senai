Console.WriteLine("Digite um valor em Gigabytes");

double valorgb = double.Parse(Console.ReadLine()!);
double valormb = valorgb * 1024;

Console.WriteLine($"Seu valor em Megabytes É: {valormb}");