// Repetição para validar entrada em variáveis

//float notaBimestral;

//do
//{
//    Console.Clear();
//    Console.WriteLine("Digite uma nota válida [0 a 10]: ");
//    notaBimestral = float.Parse(Console.ReadLine());

//    if (notaBimestral < 0 || notaBimestral > 10)
//    {
//        Console.WriteLine("Nota Inválida!!!");
//        Console.ReadKey();

//    }

//} while(notaBimestral < 0 || notaBimestral > 10);    

//List<string> listaPessoas = new List<string>();
//string nome;

//do
//{
//    Console.WriteLine("Digite um nome de pessoa ou a palavra SAIR para encerrar o programa: ");
//    nome = Console.ReadLine().ToUpper();

//    if(nome == "SAIR")
//    {
//        break; //encerra a repetição
//    }
//    listaPessoas.Add(nome);

//}while(true);

////listaPessoas = [ 0, 1, 2, 3, ..,n]
//for(int i = 0; i < listaPessoas.Count; i++)
//{
//    Console.WriteLine(listaPessoas[i]);
//}

int valorGlicemia; //45 a 450
List<int> listaGlicemias = new List<int>();

int TOTAL = 5;
for (int i = 0; i < TOTAL; i++)
{

    do
    {
        Console.Write("Digite um valor de glicemia válido [45 a 450]: ");
        valorGlicemia = int.Parse(Console.ReadLine());
        if (valorGlicemia >= 45 && valorGlicemia <= 450)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido. Atente para 45 a 450!");
        }
    } while (true);

    listaGlicemias.Add(valorGlicemia);

}

for (int i = 0; i < listaGlicemias.Count; i = i + 1)
{
    Console.WriteLine(listaGlicemias[i]);
}