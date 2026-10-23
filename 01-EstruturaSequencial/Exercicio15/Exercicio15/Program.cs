Console.WriteLine("Digite Quanto Ganha por Hora");
double ganhohr = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite Quantas Horas Trabalhadas por Mês");
double hrstrabalhadas = double.Parse(Console.ReadLine()!);

double salarioBruto = ganhohr * hrstrabalhadas;
double imposto = salarioBruto * 0.11;
double INSS = salarioBruto * 0.08;
double sindicato = salarioBruto * 0.05;
double descontos = imposto + INSS + sindicato;
double SalarioLiquido = salarioBruto - descontos;

Console.WriteLine($"Seu Salário Bruto É: {salarioBruto}");
Console.WriteLine($"O Valor do Seu Imposto de Renda Será: {imposto}");
Console.WriteLine($"O Quanto você Irá Pagar ao INSS É: {INSS}");
Console.WriteLine($"O Seu Salário Liquido Será: {SalarioLiquido}");