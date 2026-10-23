Console.WriteLine("Informe o Peso dos Peixes que João Pescou");

double peso = double.Parse(Console.ReadLine()!);
double excesso = peso - 50;
double multa = excesso * 4.0;

Console.WriteLine($"O Excesso do Peso dos Peixes de João É: {excesso}");
Console.WriteLine($"O Valor que João Terá que Pagar de Multa É: {multa}");