Console.WriteLine("Digite 2 números inteiros e 1 número real.");

Console.WriteLine("Digite o primeiro número inteiro.");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o segundo número inteiro.");
int num2 = int.Parse(Console.ReadLine()!);

double dobronum1 = num1 * 2.0;
double metadenum2 = num2 / 2.0;
double produto = dobronum1 * metadenum2;

Console.WriteLine("Digite um número Real");
double numreal = double.Parse(Console.ReadLine()!);

double multiplicação = num1 * 3.0;
double soma = multiplicação + numreal;
double realaocubo = (numreal * numreal * numreal);

Console.WriteLine("O Produto do Dobro do Primeiro com a Metade do Segundo");
Console.WriteLine(produto);

Console.WriteLine("A Soma do Triplo do Primeiro com o Terceiro");
Console.WriteLine(soma);

Console.WriteLine("O Terceiro Elevado ao Cubo");
Console.WriteLine(realaocubo);