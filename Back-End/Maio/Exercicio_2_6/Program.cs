// Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura
// (metros) e o peso (kg) de uma pessoa.
// O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua
// situação conforme a tabela.
// O cálculo do imc = peso / (altura * altura)
// 
// IMC
// menor que 18                -> baixo peso
// maior que 18 e menor que 25 -> peso normal
// maior que 25 e menor que 30 -> sobrepeso
// maior que 30 e menor que 35 -> obesidade
// maior que 35                -> obesidade grau sério
//

string paciente;
string situacao;
double altura;
double peso;
double imc;


Console.WriteLine("Entre com o seu primeiro nome:");
paciente = Console.ReadLine();
paciente = paciente.ToUpper();


Console.WriteLine("Entre com a sua altura(m) e depois peso(kg):");
altura = double.Parse( Console.ReadLine());
peso = double.Parse( Console.ReadLine());
//altura = 1.90;
//peso = 120;

situacao = "triste";

imc = peso / (altura*altura);

if (imc < 18)
{
    situacao = " baixo peso ";
}

if (imc >= 18 && imc < 25)
{
    situacao = " peso normal ";
}

if (imc >= 25 && imc < 30)
{
    situacao = " sobrepeso ";
}

if (imc >= 30 && imc < 35)
{
    situacao = " obesidade ";
}

if (imc >35)
{
    situacao = " obesidade perigosa ";
}

Console.WriteLine(paciente + " seu IMC é de " + Math.Round(imc) + " sua situação corpórea é " + situacao);