// Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros
// quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para
// cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
// Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

double areaPintada, precoTotal, quantidadeLatas, litros;


Console.WriteLine("Qual a área a ser pintada em M²?");
areaPintada = double.Parse(Console.ReadLine());

litros = areaPintada / 3;

quantidadeLatas = litros / 18;

quantidadeLatas = Math.Round(quantidadeLatas);

precoTotal = quantidadeLatas * 80;

Console.WriteLine("Você precisará de " + quantidadeLatas + " latas ao custo de R$" + precoTotal);