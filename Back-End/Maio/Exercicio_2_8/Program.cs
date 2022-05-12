// Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um
// funcionário.
// Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total
// de vendas.
// Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total
// de vendas.
// E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10%
// do total de vendas.
String nome;
double salarioBase;
double totalDeVendas;
double salarioFinal;
double totalFinal;

Console.WriteLine("Entre com o nome do vendedor:");
nome = Console.ReadLine();

Console.WriteLine("Qual o salário base?");
salarioBase = double.Parse(Console.ReadLine());

Console.WriteLine("Qual é o total de vendas?");
totalDeVendas = double.Parse(Console.ReadLine());

salarioFinal = salarioBase + totalDeVendas;

if (totalDeVendas >= 500 && totalDeVendas < 1000)
{
    totalFinal = salarioFinal * 1.05;
    Console.WriteLine("Salário com o bônus de 5% é R$" + totalFinal);

} else if (totalDeVendas >= 1000 && totalDeVendas < 5000)
{

    totalFinal = salarioFinal * 1.07;
    Console.WriteLine("Salário com o bônus de 7% é R$" + totalFinal);

} else if (totalDeVendas >= 5000)
{

    totalFinal = salarioFinal * 1.10;
    Console.WriteLine("Salário com o bônus de 10% é R$" + totalFinal);

}