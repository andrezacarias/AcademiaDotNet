// Escreva um algoritmo para o jogo de adivinhação do número secreto.
// O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
// plus: você pode gerar o número de forma randomica (função random c#).

int numero;
Random numeroAleatorio = new Random();
int numeroSorteado = numeroAleatorio.Next(1, 10);

Console.WriteLine("Entre com um numero inteiro:");
numero = int.Parse(Console.ReadLine());

if (numeroSorteado == numero)
{
    Console.WriteLine("Você acertou!");

}else if(numeroSorteado > numero)
{
    Console.WriteLine("Número Sorteado é MAIOR!");

}else if( numeroSorteado < numero)
{
    Console.WriteLine("Número Sorteado é MENOR!");
}

Console.WriteLine("\n" + numeroSorteado);