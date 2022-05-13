﻿// Faça um programa em VS que solicite um número inteiro positivo ao usuário,
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


// Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
// informar um outro número. Caso positivo, o programa em VS deve ser repetido.

int numeroInteiro, par = 0;
string repete;

do
{
    Console.Write("Digite um número inteiro entre 1 e 50:");
    numeroInteiro = int.Parse(Console.ReadLine());

        Console.WriteLine($"O número digitado foi : {numeroInteiro}");

Console.Clear();

if (par < numeroInteiro)
    {
        for (par = 0; par <= numeroInteiro; par++)
        {
            if (par % 2 == 0)
            {
                Console.WriteLine(par);
            }
        }
    }

    Console.WriteLine("Deseja digitar outro número? (S/N)");
    repete = Console.ReadLine().ToUpper();
    Console.Clear();

}while (repete != "N");