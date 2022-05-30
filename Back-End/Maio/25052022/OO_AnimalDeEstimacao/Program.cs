/*Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário 
armazene/leia os dados dos dois dados privados (propriedades).*/

using OO_AnimalDeEstimacao;

Console.WriteLine("Vou apresentar meus bichos de estimação!");
String nome="", especie="";
int contadorGato=0, contadorCachorro=0, contadorPeixe=0;
for (int i = 0; i < 6; i++)
{

    Console.WriteLine("Digite o nome do bicho: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite a espécie do bicho: ");
    especie = Console.ReadLine().ToLower();


    if (especie == "gato" || especie == "cachorro" || especie == "peixe")
    {
        if (especie == "gato")
        {
            contadorGato++;
        }
        else if (especie == "cachorro")
        {
            contadorCachorro++;
        }
        else if (especie == "peixe")
        {
            contadorPeixe++;

        }
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Digite uma espécie válida (cachorro/gato/peixe).");
        i--;
    }


}

    BichoDeEstimacao m = new BichoDeEstimacao(nome, especie , contadorGato, contadorCachorro, contadorPeixe );
    m.mostraAnimalDeEstimacao();

