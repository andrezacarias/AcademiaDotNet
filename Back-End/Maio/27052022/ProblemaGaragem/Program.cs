//Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de Listas e Arquivos.
//Além disso, aplicar a ideia de menu de opções.

//Construa um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. Os dados dos
//veículos devem ser persistentes em arquivos e manipulados em uma lista dinâmica em memória.
//Os dados dos veículos são : string placa; DateTime dataHoraEntrada.

//CARDÁPIO
//1 - Cadastrar veículo na loja
//2 - Exibir veículos cadastrados
//3 - Sair
//Opção:

//Observações: Criar uma aula Veiculo (placa, dataHoraEntrada); usar como classes List, StreamReader, StreamWriter, DateTime
//Use como base de dados o arquivo 'garagem.dat'.

//StreamReader, StreamWriter, List, veiculo

using ProblemaGaragem;

List<Veiculo> listaVeiculo = new List<Veiculo>();
string opcao;

//popular a lista com dados do arquivo
Util.carregarListas(listaVeiculo);

do
{

    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar um veículo");
    Console.WriteLine("2 - Listar veículos");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
            //cadastrar um veículo;
            Util.cadastrarVeiculo("Cadastrando veículo", listaVeiculo);
            break;
        case "2":
            //listar veículo;
            Util.exibirLista("Exibindo a lista de veículos", listaVeiculo);
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");

