//Faça um algoritmo para calcular e mostrar a área de um triângulo a partir
//dos valores da base e da altura
//lidos pelo teclado: Área do triangulo = (base * altura) / 2;
//Teste se a base ou a altura digitada não foi igual a zero.

double bas;
double altura;
double area;

Console.WriteLine("Digite a base e altura");
bas =  double.Parse(Console.ReadLine());
altura = double.Parse(Console.ReadLine());  

if (bas == 0)
{
    Console.WriteLine("Base ou Altura não podem ser Zero!");
   

}
else if(altura == 0)
{
    Console.WriteLine("Base ou Altura não podem ser Zero!");

} else
{
    area = (bas * altura) / 2;
    Console.WriteLine("A área total do triângulo " + area + "cm²");

}