// See https://aka.ms/new-console-template for more information
Console.WriteLine("Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior\n" + 
"do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis.\n" +
"Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;\n"+
"se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.\n"+
"Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor \n"+
"da entrada e das duas prestações, de acordo com as regras acima.\n"+ 
"Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o\n" +
"conseqüente pagamento dos boletos das duas prestações.");

double valordacompra, entrada, prestacao, saldo;
int parcelas;

Console.WriteLine("Qual o valor da compra?");
valordacompra = float.Parse(Console.ReadLine());

Console.WriteLine("Qual o número de parcelas?");
parcelas = int.Parse( Console.ReadLine());

prestacao = Math.Floor(valordacompra / parcelas);

saldo = prestacao * (parcelas - 1);

entrada = valordacompra - saldo;

Console.WriteLine("O valor da entrada é de R$ " + entrada);

Console.WriteLine("E mais " + (parcelas - 1) + " parcelas de R$ " + prestacao);


