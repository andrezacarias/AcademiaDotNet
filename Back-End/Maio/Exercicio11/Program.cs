// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva um algoritmo para ler o número de eleitores de um município,\n" +
"o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um\n" +
"representa em relação ao total de eleitores.");

double numeroeleteitores;
double numerobranco;
double numeronulo;
double numerovalido;
double pbranco;
double pnulo;
double pvalido;

Console.WriteLine("Entre com o numero de eleitores :");
numeroeleteitores = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com o numero de votos brancos :");
numerobranco = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com o numero de votos nulos :");
numeronulo = double.Parse(Console.ReadLine());

numerovalido = numeroeleteitores - numerobranco- numeronulo;

pvalido = numerovalido/ numeroeleteitores * 100 ;

pbranco = numerobranco/ numeroeleteitores *100;

pnulo = numeronulo/ numeroeleteitores *100;

Console.WriteLine("A porcentagem de votos Válidos é de " + pvalido + "% dos votos.");

Console.WriteLine("A porcentagem de votos em branco é de " + pbranco + "% dos votos.");

Console.WriteLine("A porcentagem de votos nulos é de " + pnulo + "% dos votos.");
