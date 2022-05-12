// Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a
// média das duas notas for maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa deve ler
// a nota do exame e calcular a média final. Se esta média for maior ou igual a 5,0, o programa deve
// escrever “Aprovado”, caso contrário deve escrever “Reprovado”.

double nota1;
double nota2;
double exame;
double media;
double notaExame;
double mediaExame;

Console.WriteLine("Entre com as notas das duas provas:");
nota1 = double.Parse(Console.ReadLine());
nota2 = double.Parse(Console.ReadLine());

media = (nota1 + nota2)/2;

if (media >= 7)
{
    Console.WriteLine("Aluno Aprovado!");
    Console.WriteLine("Nota final " + media);

}
else
{
    Console.WriteLine("Nota final " + media);
    Console.WriteLine("Nota menor que o suficiente entre com a nota do exame:");
    notaExame = double.Parse(Console.ReadLine());
    mediaExame = (media + notaExame)/2;

    if(mediaExame >= 7)
    {
        Console.WriteLine("Aluno Aprovado!");
    }
    else
    {
        Console.WriteLine("Aluno Reprovado!");
    }
}