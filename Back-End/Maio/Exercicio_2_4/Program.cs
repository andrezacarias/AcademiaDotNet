// Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora
// recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

double horaAula1, horaAula2, salario1, salario2, jornada1, jornada2;

Console.WriteLine("Entre com o valor de hora/aula dos dois professores.");
horaAula1 = double.Parse(Console.ReadLine());
horaAula2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com a joranada dos dois professores.");
jornada1 = double.Parse(Console.ReadLine());
jornada2 = double.Parse(Console.ReadLine());

salario1= horaAula1 * jornada1;
salario2= horaAula2 * jornada2;

if (salario1 > salario2)
{
    Console.WriteLine("O professor número 1 tem o maior salário! O salário é R$ " + salario1);

}
else
{
    Console.WriteLine("O professor número 2 tem o maior salário! O salário é R$ " + salario2);

}


