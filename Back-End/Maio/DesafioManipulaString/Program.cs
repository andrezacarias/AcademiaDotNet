//Exercícios desafio de string
//Fazer um programa que receba  o nome completo de uma pessoa e
//exiba em maiúsculo o primeiro nome e o último sobrenome dessa pessoa.

//Fazer um programa que receba o nome completo de uma pessoa e o
//exiba abreviado

String nomeCompleto;
String nome;
String sobreNome;
String [] nomeTemporario;


Console.WriteLine("Entre com o seu nome completo:");
nomeCompleto = Console.ReadLine();
nomeCompleto = nomeCompleto.ToUpper();

nomeTemporario = nomeCompleto.Split(" ");
nome = nomeTemporario[0];
sobreNome = nomeTemporario[nomeTemporario.Length - 1];
Console.WriteLine(nome);
Console.WriteLine(sobreNome);

