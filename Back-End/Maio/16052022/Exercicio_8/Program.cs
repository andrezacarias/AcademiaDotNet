// Faça um programa em VS que solicite um numero inteiro.
// Se o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
// Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

int numero = 0;
string resposta;


do
{
    do
    {
        Console.WriteLine("Digite um número inteiro");
        numero = int.Parse(Console.ReadLine());
    }while(numero == 0);

    if (numero % 2 == 0)
    {
        Console.WriteLine("Esse número é par!");
    }
    else
    {
        Console.WriteLine("Esse número é ímpar!");
    }

    Console.WriteLine("Deseja digitar mais valores?(S/N)");
    resposta = Console.ReadLine();
    resposta=resposta.ToUpper();
    
    switch (resposta)
    {
        case "S":
            numero = 0;
            Console.Clear();
            break;
            
        case "N":
            numero = 1;
            Console.WriteLine();
            Console.WriteLine("ATÉ MAIS!!!");
            break;
        
    }
    
    

} while (numero == 0);