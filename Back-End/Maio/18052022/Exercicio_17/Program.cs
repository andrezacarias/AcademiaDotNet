// 17. Apresentar os quadrados dos números inteiros de 15 a 200.

double potencia, count;

for (double i = 15; i <= 20; i++)
{
    potencia = i * i;
    Console.WriteLine($"O número {i} ao quadrado é { potencia}.");
    

    if (i >= 20)
    {
        count = i - 15;
        Console.WriteLine();
        Console.WriteLine($"Foram processados {count} números!");
        Console.WriteLine();

    }
}
