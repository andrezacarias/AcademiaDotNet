// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.\n" +
"Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de\n" +
"custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço\n" +
"de custo de cada bicicleta e o número de bicicletas vendidas pelo vendedor, calcule e mostre: o salário\n" +
"do empregado");

double salariominimo;
double salariomaximo;
double custobike;
double bikevendas;

Console.WriteLine("Qual o salário mínimo?");
salariominimo = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o custo de cada Bike?");
custobike = double.Parse(Console.ReadLine());

Console.WriteLine("Quantas bikes vendidas?");
bikevendas = double.Parse(Console.ReadLine());

salariomaximo = (salariominimo * 2) + ((bikevendas * custobike) * .15);

Console.WriteLine("O salário total do vendedor é de R$" + salariomaximo);
