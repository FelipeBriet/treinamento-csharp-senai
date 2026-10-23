Console.WriteLine("Digite quanto você ganha por hora");
double ganhohr = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite quantas horas você trabalha por mês");
double horas = double.Parse(Console.ReadLine()!);

double salario = ganhohr * horas;

Console.WriteLine($"O Seu salário por Mês É: {salario}");
