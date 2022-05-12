// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel\n" +
    " (medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível\n" +
    " consumido para percorrê - la(medido em l).");

int litros;
int distancia;
float media;

Console.WriteLine("Qual a distância percorrida pelo possante?");
distancia = Int16.Parse(Console.ReadLine());

Console.WriteLine("Quantos litros o possante consumiu?");
litros = Int16.Parse(Console.ReadLine());

media = distancia / litros;

Console.WriteLine("Parabéns! A média de consumo do possante é " + media + "km/l!");

