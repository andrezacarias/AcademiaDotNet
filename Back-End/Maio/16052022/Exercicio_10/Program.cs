// Ler nome, sexo e idade de 50 pessoas e após imprimir:
// Número de pessoas do sexo masculino.
// Número de pessoas do sexo feminino.
// Número de pessoas com idade inferior a 30 anos.
// Número de pessoas com idade superior a 60 anos.
// Média de idade das mulheres.

string nome, sexo;
int idade, numeroHomem=0, numeroMulher=0, menorDeTrinta=0, maiorDeSessenta=0, idadeMulher = 0; 
double mediaIdadeMulheres = 0;

for (int i = 0; i <= 50; i++) {

    Console.Write("Qual é seu nome? ");
    nome = Console.ReadLine();

    Console.Write("Você é (H)omem ou (M)ulher? ");
    sexo = Console.ReadLine().ToUpper();

    Console.Write("Qual sua idade? ");
    idade = int.Parse(Console.ReadLine());

    switch (sexo)
    {
        case "H":
            numeroHomem++;
            break;

        case "M":
            numeroMulher++;
            idadeMulher = idadeMulher + idade;
            break;
    }

    if ( idade <= 30 )
    {
        
        menorDeTrinta++;
    
    }else if( idade>=60 ){

        maiorDeSessenta++;

    }

}

Console.WriteLine("Resultados da Pesquisa:");
Console.WriteLine();
Console.WriteLine($"O número de Homens é {numeroHomem}");
Console.WriteLine($"O número de Mulheres é {numeroMulher}");
Console.WriteLine($"O número de pessoas menores de 30 anos é {menorDeTrinta}");
Console.WriteLine($"O número de pessoas maiores de 60 anos é {maiorDeSessenta}");
Console.WriteLine($"A media de idade das mulheres é {idadeMulher / numeroMulher} anos");
