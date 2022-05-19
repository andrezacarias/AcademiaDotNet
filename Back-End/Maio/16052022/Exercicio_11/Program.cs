// Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
// a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.

float nota, somaNotas;
int i=0;
List<float> notaTransferida = new List<float>();

do
{
    Console.Write("Entre com a nota:");
    nota = float.Parse(Console.ReadLine());
    notaTransferida.Add(nota);
    i++;
} while (nota != 12);


notaTransferida.Sort();

somaNotas = notaTransferida.Sum() -12;

Console.WriteLine($"A menor nota é {notaTransferida[0]}");
Console.WriteLine($"A maior nota é {notaTransferida[notaTransferida.Count - 2]}");
Console.WriteLine($"O número de alunos é {i-1}");
Console.WriteLine($"A média de notas é {somaNotas / (i-1)}");