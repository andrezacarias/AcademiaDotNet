// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num;
Console.WriteLine("Digite um número:");
num = int.Parse(Console.ReadLine());

if (num > 0) {

    Console.WriteLine("Positivo!");
}
else if (num < 0) {
    Console.WriteLine(" Negativo!");
}else
{
    Console.WriteLine("Zero!");
}