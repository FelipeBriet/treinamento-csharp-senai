Console.WriteLine("Digite uma temperatura em graus Fahrenheit");

double fahrenheit = double.Parse(Console.ReadLine()!);
double celsius = 5.0 * ((fahrenheit - 32.0) / 9.0);

Console.WriteLine($"Sua Temperatura em Celsius É {celsius}");