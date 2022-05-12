// Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que
// calcule seu peso ideal, utilizando as seguintes fórmulas:
// Para homens: (72.7 * h) - 58
// Para mulheres: (62.1 * h) - 44.7

int genero;
double altura, pesoIdeal;

Console.WriteLine("Especifique se for HOMEM (0) ou MULHER (1) :");
genero = int.Parse( Console.ReadLine());
Console.WriteLine("Especifique a altura do paciente x,xxM");
altura = double.Parse(Console.ReadLine());

if (genero == 0 )
{
    pesoIdeal = (72.7 * altura) - 58.0;
    Console.WriteLine("O gênero do paciente é homem e seu peso ideal é " + pesoIdeal + "Kg.");
}
else
{
    pesoIdeal = (62.1 * altura) - 44.7;
    Console.WriteLine("O gênero do paciente é mulher e seu peso ideal é " + pesoIdeal + "Kg.");
}

