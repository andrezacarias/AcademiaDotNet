// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B,\n" + 
"isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem\n"+
"de IPI(única) a ser acrescentada. ");

//int parafusoA;
//int parafusoB;
string codigoA;
string codigoB;
int quantidadeA;
int quantidadeB;
float aliquota;
float precoA;
float precoB;
float valortotal;
float valortotalcomimposto;

Console.WriteLine("Qual é o código do parafuso A?");
codigoA = Console.ReadLine();

Console.WriteLine("Qual é o código do parafuso B?");
codigoB = Console.ReadLine();

Console.WriteLine("Qual é a quantidade do parafuso " + codigoA + " ?");
quantidadeA = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a quantidade do parafuso " + codigoB + " ?");
quantidadeB = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o preço do parafuso " + codigoA + " ?");
precoA = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é preço do parafuso " + codigoB + " ?");
precoB = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é a aliquota de IPI do seu estado?");
aliquota = float.Parse(Console.ReadLine());


valortotal = (quantidadeA * precoA) + (quantidadeB * precoB);

valortotalcomimposto = valortotal * (aliquota/100) + valortotal;

Console.WriteLine("O preço dos parafusos código " + codigoA + " e código " + codigoB + " é de R$ " + valortotal + ", \n" +
    " sem IPI e R$ " + valortotalcomimposto + " com IPI.");
