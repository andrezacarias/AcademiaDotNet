double numero, expoente, resultado=1;

Console.WriteLine("Numero");
numero = double.Parse(Console.ReadLine());

Console.WriteLine("Expoente");
expoente = double.Parse(Console.ReadLine());

for(int i = 0; i < expoente; i++)
{
    resultado = resultado * numero;
}

Console.WriteLine(resultado);