// Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
// a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.

int nota;
List<int> notaTransferida = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write("Entre com a nota:");
    nota = int.Parse(Console.ReadLine());
    notaTransferida.Add(nota);
}

for (int i = 0; i < notaTransferida.Count; i++)
{
    Console.WriteLine("****************");
    Console.WriteLine(notaTransferida[i]);
}

notaTransferida.Sort();



Console.WriteLine($"A menor nota é {notaTransferida[0]}");
Console.WriteLine($"A maior nota é {notaTransferida[notaTransferida.Count - 1]}");