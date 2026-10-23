Console.WriteLine("Digite a Medida do Lado de Um Quadrado Para que Seja Calculado a Área e após isso, o dobro de sua Área:");

Console.WriteLine("Digite a medida do Lado do Quadrado");

double lado = double.Parse(Console.ReadLine()!);
double area = lado * lado;
double area2 = area * 2;

Console.WriteLine("O Quadrado da sua Área é:");
Console.WriteLine(area2);