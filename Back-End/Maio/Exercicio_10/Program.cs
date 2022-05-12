// See https://aka.ms/new-console-template for more information
Console.WriteLine("Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo\n" +
"para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que\n" +
"realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as\n" +
"notas de menor valor fossem distribuídas em número mínimo possível.\n" +
"Por exemplo, se a quantia solicitada fosse R$ 87, 00 o programa deveria indicar uma nota de R$ 50,00,\n" +
"três notas de R$ 10, 00, uma nota de R$ 5, 00 e duas notas de R$ 1, 00.\n" +
"Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas\n" +
"de acordo com o critério da “distribuição ótima."
);

int valordosaque, nota, quantidade, resto;

Console.WriteLine("Entre com o valor do Saque.");
valordosaque = int.Parse(Console.ReadLine());

nota = 200;
quantidade = valordosaque / nota;
resto = valordosaque % nota;
if (quantidade > 0){
    Console.WriteLine("São " + quantidade + " notas de R$200.");
}
//Console.WriteLine("Resto " + resto);

nota = 100;
quantidade = resto / nota;
resto = resto % nota;
if(quantidade > 0) { 
    Console.WriteLine("São " + quantidade + " notas de R$100.");
}

//Console.WriteLine("Resto " + resto);

nota = 50;
quantidade = resto / nota;
resto = resto % nota;
if (quantidade > 0){    
    Console.WriteLine("São " + quantidade + " notas de R$50.");
}
//Console.WriteLine("Resto " + resto);

nota = 20;
quantidade = resto / nota;
resto = resto % nota;
if (quantidade > 0){
    Console.WriteLine("São " + quantidade + " notas de R$20.");
}
//Console.WriteLine("Resto " + resto);

nota = 10;
quantidade = resto / nota;
resto = resto % nota;
if (quantidade > 0){
    Console.WriteLine("São " + quantidade + " notas de R$10.");
}
//Console.WriteLine("Resto " + resto);

nota = 5;
quantidade = resto / nota;
resto = resto % nota;
if (quantidade > 0){
    Console.WriteLine("São " + quantidade + " notas de R$5.");
}
//Console.WriteLine("Resto " + resto);

nota = 2;
quantidade = resto / nota;
resto = resto % nota;
if (quantidade > 0){
    Console.WriteLine("São " + quantidade + " notas de R$2.");
}
//Console.WriteLine("Resto " + resto);



