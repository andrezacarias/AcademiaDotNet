// Faça um programa em VS que solicite um número inteiro positivo ao usuário,
// validando a entrada de dados 
// (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
// Após o programa em VS deve informar todos os números pares existentes entre 1 e o
// número fornecido pelo usuário.

// Exemplo:
// Digite um número inteiro positivo: -8
// Valor incorreto!
// Digite um número inteiro positivo: 8
// Numero digitado: 8
// Números inteiros pares entre 1 e 8: 2, 4, 6.

int numeroInteiro;
int par =0;

do
{

    Console.Write("Digite um número inteiro entre 1 e 50:");
    numeroInteiro = int.Parse(Console.ReadLine());
    if (numeroInteiro > 0 && numeroInteiro <= 50)
    {   
        Console.WriteLine("Número digitado: " + numeroInteiro);
        break;
    }
    else
    {
        Console.WriteLine("Valor deve ser entre 1 e 50!");

    } 

} while (true);

while(par <= numeroInteiro - 2)
{
    
    Console.Write((par = par + 2) + ",");
       
}