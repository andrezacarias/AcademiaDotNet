using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGaragem
{
    class Util
    {
                     
        public static void exibirLista(string frase, List<Veiculo> listaVeiculo)
        {
            Console.WriteLine(frase);
            foreach (Veiculo i in listaVeiculo)
            {
                Console.WriteLine(i.Placa + " - " + i.DataHoraEntrada);
               
            }
        }

        public static void carregarListas(List<Veiculo> listaVeiculo)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.txt";
            string[] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //placa;horaDeEntrada
                   listaVeiculo.Add(new Veiculo(vetorDados[0], DateTime.Now));
                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Veículo já cadastrado");
            }
            
        }

        
        private static void gravarArquivo(Veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.txt", true);

                escritor.WriteLine(objeto.Placa + ";" + objeto.DataHoraEntrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veiculos com problemas" + e.Message);
            }
        }


        public static void cadastrarVeiculo(string frase, List<Veiculo> listaVeiculo)
        {
            Console.WriteLine(frase);
            string placa;
         
            Console.Write("Digite a placa: ");
            placa = Console.ReadLine();
            DateTime DataHoraEntrada = DateTime.Now;

            Veiculo objeto = new Veiculo(placa, DataHoraEntrada);
            //Veiculo objeto = new Veiculo(placa, DateTime.Now);
            listaVeiculo.Add(objeto);
            //gravar no arquivo
            Util.gravarArquivo(objeto);


        }
    }
}