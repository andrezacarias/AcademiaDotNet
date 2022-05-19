// Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
// o zoológico num determinado dia, imprimindo:
// Quantas pessoas tem entre 1 e 3 filhos.
// Quantas pessoas tem entre 4 e 7 filhos.
// Quantas pessoas tem mais de 8 filhos.
// Quantas pessoas não tem filhos.

int numeroDeFilhos = 0;
int opcao1 = 0, opcao2 = 0, opcao3 = 0, opcao4 = 0, opcaoInvalida = 0;

for(int i = 0; i <= 30; i++)
{
    Console.Clear();
    Console.WriteLine("Selecione a sua faixa de filhos:\n\n"+
        "1 - De 1 a 3 filhos\n2 - De 4 a 7 filhos\n3 - Mais de 8 filhos\n4 - Não tenho filhos");
    Console.WriteLine();
    numeroDeFilhos = int.Parse(Console.ReadLine());

    switch (numeroDeFilhos)
    {
        case 1:
            opcao1++;
            break;
        case 2:
            opcao2++;
            break;
        case 3:
          opcao3++;
            break;
        case 4:
            opcao4++;
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Opção Inválida!");
            opcaoInvalida++;
            break;
    }
    Console.WriteLine();
    Console.WriteLine("Muito obrigado por responder a nossa pesquisa.");
    Console.WriteLine("O ZOO SP agradece sua visita.");
    Console.ReadKey();
}
Console.Clear();
Console.WriteLine("Resultado da pesquisa:");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"{opcao1} pessoas tem entre 1 e 3 filhos.");
Console.WriteLine($"{opcao2} pessoas tem entre 4 e 7 filhos.");
Console.WriteLine($"{opcao3} pessoas tem mais de 8 filhos.");
Console.WriteLine($"{opcaoInvalida} pessoas não responderam.");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");