

int totalGeral=0;
List<int> transito = new List<int>();

for(int i =0; i <= 500; i++)
{
    if(i % 2 == 0) { 

        transito.Add(i);
        //Console.WriteLine($"Entrei aqui{i}");
        
    }
}

totalGeral = transito.Sum();
Console.WriteLine("*****************************************************");
Console.WriteLine("*                                                   *");
Console.WriteLine($"*    A soma dos quinhentos números pares é {totalGeral}    *");
Console.WriteLine("*                                                   *");
Console.WriteLine("*****************************************************");
