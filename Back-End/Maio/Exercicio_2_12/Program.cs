// Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente
// código e número de horas trabalhadas de um operário. Na sequência, calcule o salário
// sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o
// excesso de pagamento armazenando-o na variável "extra", caso contrário zerar tal variável.
// A hora excedente de trabalho vale R$ 20,00. 
// No final do processamento, exibir o salário total e o salário excedente do operário.

string codigo;
int numeroHoras;
double extra, salario, salarioTotal;

Console.WriteLine("Entre com o código do funcionário e a quantidade de horas trabalhadas:");
codigo = Console.ReadLine();
numeroHoras = int.Parse(Console.ReadLine());

salario = numeroHoras * 10;

if(numeroHoras > 50)
{
    extra = (numeroHoras - 50) * 20;
    salarioTotal = salario + extra;

    Console.WriteLine("O funcionário " + codigo + " teve um salário de total de R$ " + salarioTotal);
}
else
{
    extra = 0;

    Console.WriteLine("O funcionário " + codigo + " teve um salário de total de R$ " + salario);
}

