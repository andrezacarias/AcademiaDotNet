// See https://aka.ms/new-console-template for more information
Console.WriteLine("Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que\n" +
"o preço do combustível é de R$6,90, escreva um algoritmo para ler a marcação do odômetro \n" +
"(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível\n" +
"gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro \n"+
"líquido do dia.\n"+

"Fórmulas:\n" +
" Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia\n"+
"\n"+
"Média do consumo = Total quilometragem/ quantidade de combustível gasto\n"+
"\n"+
"Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)");

double km_inicial;
double km_final;
double litros;
double receita;
double media;
double lucro;
double km_total;

Console.WriteLine("Qual Km incial?");
km_inicial = double.Parse(Console.ReadLine());

Console.WriteLine("Qual Km final?");
km_final = double.Parse(Console.ReadLine());

Console.WriteLine("Quantos litros de combustível consumiu hoje?");
litros = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a receita de hoje?");
receita = double.Parse(Console.ReadLine());

km_total = km_final - km_inicial;

media = km_total / litros;

lucro = receita - (litros * 6.90);

Console.WriteLine("A média de consumo de combustível é de " + Math.Round(media, 2 ) + " km/litro.");
Console.WriteLine("O lucro do dia é de R$" + Math.Round(lucro, 2) + ".");






