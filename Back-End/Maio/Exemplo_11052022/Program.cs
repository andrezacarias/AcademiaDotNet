// See https://aka.ms/new-console-template for more information

//int m;

//for (m = 0; m < 10; m++)
//{
//    //i=i+1;

//    Console.WriteLine("m vale " + m);

//}

//Exemplo 3

//int m;

//for (m = 20; m >= 5; m--)
//{
//    //i=i+1;

//    Console.WriteLine("m vale " + m);

//}

//Exemplo 4

//int inicio, fim, i;

//Console.WriteLine("Digite o início e o fim: ");
//inicio = int.Parse(Console.ReadLine());
//fim = int.Parse(Console.ReadLine());

//if (inicio < fim)
//{
//    for (i = inicio; i <= fim; i++)
//    {


//        Console.WriteLine("Intervalo " + i);

//    }

//}else if (inicio > fim)
//{
//    for (i = inicio; i >= fim; i--)
//    {


//        Console.WriteLine("Intervalo " + i);

//    }

//}
//else
//{
//    Console.WriteLine("Inicio e fim não podem ser numeros iguais, tente novamente.");
//}




//Exemplo 5

//int i, x;

//Console.WriteLine("Digite x : ");
//x = int.Parse(Console.ReadLine());
////Incremento 


//for (i = x; i <= 100; i = i + x)
//{


//    Console.WriteLine("Intervalo " + i);

//}


//Exemplo 6

//int i, x;
//Console.WriteLine("Digite x : ");
//x = int.Parse(Console.ReadLine());


//for (i = 1; i <= 100; i ++)
//{

//    if (i % x == 0)
//    {
//        Console.WriteLine(i + " é divisível " + x);

//    }
//}

//Exemplo 7

int num, i;
Console.WriteLine("Entre com a tabuada:");
num = int.Parse(Console.ReadLine());

for (i = 1; i <= 10; i++)
{

    Console.WriteLine(i + " x " + num + " = " + i * num);

}
