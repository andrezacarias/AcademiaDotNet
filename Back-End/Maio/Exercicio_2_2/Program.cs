//Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

int num;
int par;

Console.WriteLine("Digite um numero qualquer:");
num = int.Parse(Console.ReadLine());

par = num % 2;

if (par == 0)
{
    Console.WriteLine("O número é PAR!");
}
else
{
    Console.WriteLine("O número é IMPAR!");
}


