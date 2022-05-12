// Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando
// a medição diária de um paciente diabético. Para cada valor recebido analisar e informar ao
// paciente o seguinte:
// Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
// Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
// Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.
// E se a média for menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina.
// Se a média for maior que 150, avisá-lo que será necessário adicionar 2 unidades de insulina.



double glicemia1;
double glicemia2;
double glicemia3;
double media;

Console.WriteLine("Entre com o valor das 3 medicões de hoje:");
glicemia1 = double.Parse(Console.ReadLine());
glicemia2 = double.Parse(Console.ReadLine());
glicemia3 = double.Parse(Console.ReadLine());

if(glicemia1 <= 65 || glicemia1 >= 250)
{
    if(glicemia1 <= 65)
    {
        
        Console.WriteLine("Você está em risco de HIPOGLICEMIA pela primeira medição");

    }else
    {
        
        Console.WriteLine("Você está em risco de HIPERGLICEMIA pela primeira medição");

    }
}

if (glicemia2 <= 65 || glicemia2 >= 250)
{
    if (glicemia2 <= 65)
    {

        Console.WriteLine("Você está em risco de HIPOGLICEMIA pela segunda medição");

    }
    else
    {

        Console.WriteLine("Você está em risco de HIPERGLICEMIA pela segunda medição");

    }
}

if (glicemia3 <= 65 || glicemia3 >= 250)
{
    if (glicemia3 <= 65)
    {

        Console.WriteLine("Você está em risco de HIPOGLICEMIA pela terceira medição");

    }
    else
    {

        Console.WriteLine("Você está em risco de HIPERGLICEMIA pela terceira medição");

    }
}

media = (glicemia1 + glicemia2 + glicemia3) / 3;

if(media <= 80 || media >= 150)
{
    if(media <= 80)
    {
        Console.WriteLine("Você precisa DIMINUIR 02 doses de insulina!");
    }
    else
    {
        Console.WriteLine("Você precisa AUMENTAR 02 doses de insulina!");
    }
}
else
{
    Console.WriteLine("Glicemia sob controle");
}