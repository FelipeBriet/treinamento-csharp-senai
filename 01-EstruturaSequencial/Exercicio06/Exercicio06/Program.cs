Console.WriteLine("Digite o Raio de um Círculo e será mostrado sua Área.");

double raio = double.Parse(Console.ReadLine()!);
double pi = 3.14159;
double area = pi * (raio * raio);

Console.WriteLine("A Área do seu Circulo É:");
Console.WriteLine(area);