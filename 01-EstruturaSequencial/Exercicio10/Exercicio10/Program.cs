Console.WriteLine("Digite uma Temperatura em graus Celsius");

double celsius = double.Parse(Console.ReadLine()!);
double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;

Console.WriteLine($"Sua Temperatura em Fahrenheit É: {fahrenheit}");