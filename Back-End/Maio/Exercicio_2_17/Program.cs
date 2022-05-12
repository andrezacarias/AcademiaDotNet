// Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se
// esses lados podem ou não formar um triangulo. Para que os ladosformem um triângulo, todos os
// lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um
// triangulo, diga se o mesmo é equilátero (todos os lados iguais), isoceles(somente 2 lados são
// iguais) ou escaleno(os 3 lados são diferentes).

double ladoA, ladoB, ladoC;

Console.WriteLine("Digite os 3 lados do triângulo: ");
ladoA = double.Parse(Console.ReadLine());
ladoB = double.Parse(Console.ReadLine());
ladoC = double.Parse(Console.ReadLine());

if ((ladoA == ladoB && ladoC == ladoA))
{
    Console.WriteLine("Triângulo Equilátero!");

} else if((ladoA != ladoB) && (ladoB != ladoC) && (ladoA != ladoC))
{

    Console.WriteLine("Triângulo Escaleno!");

} else{

    Console.WriteLine("Triângulo Isóceles!");

}