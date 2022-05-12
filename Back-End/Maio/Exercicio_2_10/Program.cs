// Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
// O programa deve mostrar os dados do atleta mais novo e mais alto. 
//
string atleta1, atleta2;
int idade1, idade2;
double altura1, altura2;

Console.WriteLine("Digite os nomes dos 2 atletas:");
atleta1 = Console.ReadLine();
atleta2 = Console.ReadLine();

Console.WriteLine("Digite as idades dos 2 atletas:");
idade1 = int.Parse(Console.ReadLine());
idade2 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual as alturas dos 2 atletas:");
altura1 = double.Parse(Console.ReadLine());
altura2 = double.Parse(Console.ReadLine());

if(idade1 < idade2)
{
    Console.WriteLine("O atleta " + atleta1 + " é o mais jovem.");
}
else
{
    Console.WriteLine("O atleta " + atleta2 + " é o mais jovem.");
}

if (altura1 > altura2)
{
    Console.WriteLine("O atleta " + atleta1 + " é o mais alto.");
}
else
{
    Console.WriteLine("O atleta " + atleta2 + " é o mais alto.");
}