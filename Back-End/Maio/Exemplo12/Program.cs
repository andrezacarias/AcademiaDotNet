double num1, num2, resultado;
int op;
Console.WriteLine("Digite dois números:");
num1 = Double.Parse(Console.ReadLine());
num2 = Double.Parse(Console.ReadLine());

Console.WriteLine("\nEscolha a operação:\n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Potência\n\nEscolha:");
op = int.Parse(Console.ReadLine());

if(op == 1)
{
    resultado = num1 + num2;
    Console.WriteLine("O valor é " + resultado);

}else if (op == 2)
{
    resultado = num1 - num2;
    Console.WriteLine("O valor é " + resultado);

}else if (op == 3)
{
    resultado = num1 * num2;
    Console.WriteLine("O valor é " + resultado);

}else if (op == 4)
{
    resultado = num1 / num2;
    Console.WriteLine("O valor é " + resultado);

}else if (op == 5)
{
    resultado = Math.Pow(num1, num2);
    Console.WriteLine("\n\nO valor é " + resultado);

}