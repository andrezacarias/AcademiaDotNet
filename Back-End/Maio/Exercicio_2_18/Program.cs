// Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

int numero1, numero2, numero3;

Console.WriteLine("Digite três números inteiros:");
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());
numero3 = int.Parse(Console.ReadLine());

if ( numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine("O maior número é " + numero1);
}else if(numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine("O maior número é " + numero2);
}
else if(numero3 > numero1 && numero3 > numero2)
{
    Console.WriteLine("O maior número é " + numero3);
}