// Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
// O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem,
// como por exemplo, A palavra encontra-se na frase  ou A palavra não se encontra na frase.
//
string frase;
string palavraChave;
string palavraUltima;
string [] palavra;

Console.WriteLine("Escreva uma frase:");
frase = Console.ReadLine();

Console.WriteLine("Digite a palavra chave:");
palavraChave = Console.ReadLine();


if (frase.Contains(palavraChave))
{
    Console.WriteLine("Palavra existe!");
}
else
{
    Console.WriteLine("Palavra NÃO existe!");
}