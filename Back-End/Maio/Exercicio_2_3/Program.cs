// Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,
// e escrever na tela os que são superiores à média.
// Ajuste o exercício 3 de maneira que mostre os valores informados em ordem crescente.
int[] sequencia;
sequencia = new int[4];
int media;

Console.WriteLine("Digite quatro número inteiros:");
sequencia[0] = int.Parse(Console.ReadLine());
sequencia[1] = int.Parse(Console.ReadLine());
sequencia[2] = int.Parse(Console.ReadLine());
sequencia[3] = int.Parse(Console.ReadLine());

Array.Sort(sequencia);

media = (sequencia[0] + sequencia[1] + sequencia[2] + sequencia[3]) /4;

Console.WriteLine("Média " + media);

if (sequencia[0] > media)
{
    Console.WriteLine(sequencia[0]);

}
if (sequencia[1] > media)
{
   Console.WriteLine(sequencia[1]);

}
if (sequencia[2] > media)
{
    Console.WriteLine(sequencia[2]);

}
if (sequencia[3] > media)
{
    Console.WriteLine(sequencia[3]);

}

Console.WriteLine("A sequencia crescente dos números é " +sequencia[0] + "," + sequencia[1] + "," + sequencia[2] + "," + sequencia[3] + "!");

