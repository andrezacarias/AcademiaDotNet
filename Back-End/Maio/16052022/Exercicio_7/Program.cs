// Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
// A cada solicitação, teste se o usuário informou um valor válido. 
// Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for
// um número), informe que ele está incorreto e saia do programa em VS. 
// Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
// informe que está errada e saia. Se estiver correta, solicite o salário. 
// Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
// Se estiver correto, mostre todos os valores lidos.

string nome;
int idade, count=0;
double salario;


Console.Write("Entre com o seu nome:");
nome = Console.ReadLine().ToUpper();

if (nome.All(char.IsNumber))
{
    Console.WriteLine("Nome inválido!");
    count++;
}
if(count == 0)
{
    Console.Write("Entre com a sua idade: ");
    idade = int.Parse(Console.ReadLine());
    if(idade <= 0)
    {
        Console.WriteLine("Idade inválida!");
        count++;
    }
    if(count == 0)
    {
        Console.Write("Entre com o seu salário: ");
        salario = double.Parse(Console.ReadLine());

        if(salario <= 0)
        {
            Console.WriteLine("Salário inválido!");
            count++;
        }
        if (count == 0)
        {
            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Sua idade é {idade} anos");
            Console.WriteLine($"Seu salário é R${ salario }");
        }
    }
}