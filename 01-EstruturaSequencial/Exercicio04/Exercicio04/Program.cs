Console.WriteLine("Digite Quatro Notas Bimestrais e o Programa Irá Calcular a Média.");

Console.WriteLine("Digite Sua Primeira Nota.");
float nota1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Digite Sua Segunda Nota.");
float nota2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Digite Sua Terceira Nota.");
float nota3 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Digite Sua Quarta Nota.");
float nota4 = float.Parse(Console.ReadLine()!);

float soma = nota1 + nota2 + nota3 + nota4;
float media = soma / 4;

Console.WriteLine("Sua Média Bimestral É:");
Console.WriteLine(media);