// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, \n" + 
"o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.\n" + 
"Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.");

string numerovendedor;
float salariofixo;
float totaldevendas;
float comissao;
float salariototal;

Console.WriteLine("Qual o numero do vendedor?");
numerovendedor = Console.ReadLine();

Console.WriteLine("Qual o salário fixo do vendedor " + numerovendedor + " ?");
salariofixo = float.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor total das vendas do vendedor " + numerovendedor + " ?");
totaldevendas = float.Parse(Console.ReadLine());

Console.WriteLine("Qual a comissão do vendedor " + numerovendedor + " ?");
comissao = float.Parse(Console.ReadLine());

salariototal = salariofixo + (totaldevendas * (comissao/100));

Console.WriteLine("O salário total do vendedor " + numerovendedor + " é de R$ " + salariototal);