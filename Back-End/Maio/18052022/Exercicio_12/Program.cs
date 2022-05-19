// 12.Apresentar o total da soma dos cem primeiros números inteiros.

int i=0, totalGeral;
List<int> cemNumeros  = new List<int> ();

do
{
    i++;
    cemNumeros.Add (i);
  
}while (i < 100);

totalGeral = cemNumeros.Sum();
Console.WriteLine("************************************************");
Console.WriteLine();
Console.WriteLine($"A soma dos cem primeiros números é {totalGeral}");
Console.WriteLine();
Console.WriteLine("************************************************");
