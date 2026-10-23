Console.WriteLine("Digite a Área em Metros Quadrados.");

double area = double.Parse(Console.ReadLine()!);
double litros = area / 3;
double latas = (int)Math.Ceiling(litros / 18.0);
double preço = latas * 80.0;

Console.WriteLine($"A Quantidade de Latas que Foram Compradas São: {latas}");
Console.WriteLine($"O Preço Total de Todas as Latas É: {preço}");