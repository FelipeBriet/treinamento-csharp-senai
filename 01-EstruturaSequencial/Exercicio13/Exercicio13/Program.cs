Console.WriteLine("Digite um Valor em Gigabytes");

double valorgb = double.Parse(Console.ReadLine()!);
double valormb = valorgb * 1024;
double valorkb = valorgb * 1024 * 1024;

Console.WriteLine($"Seu Valor em Megabytes É: {valormb}");
Console.WriteLine($"Seu Valor em Kilobytes É: {valorkb}");