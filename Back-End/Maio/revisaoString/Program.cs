//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("A idéia é trabalhar com metodos/funções de algumas classes importantes: string, Random, DateTime, List");

//string frase = "Excelente turma de dotNet da Academia Atos";

//int tamanhoFrase = frase.Length;
//string fraseEmMaiusculo = frase.ToUpper();
//string fraseEmMinusculo = frase.Lower();

//string[] palavrasNaFrase = frase.Split(" ");

//bool estaContido = frase.Contains("Atos");
//int posicao = frase.IndexOf("Atos");

//Random rnd = new Random();

//int sorteio = rnd.Next();

//Console.WriteLine(sorteio);


//char letra = (char)rnd.Next(65, 91);// A..Z
//Console.WriteLine(letra);

//Classe DateTime
//DateTime dataLocal = DateTime.Now;
//Console.WriteLine(dataLocal.ToString());
//string[] dataHora = dataLocal.ToString().Split(" ");

//Console.WriteLine(dataHora[0]);
//Console.WriteLine(dataHora[1]);

////Classe List - estrutura de dados que armazena outros objetos de maneira dinâmica

//List<string> listaAlunos = new List<string>();

//listaAlunos.Add("Andréa");
//listaAlunos.Add("Paulino");
//listaAlunos.Add("Leonardo");
//listaAlunos.Add("Flávia");
//listaAlunos.Add("Leaondro");

//Console.WriteLine("Tamanho da lista: " + listaAlunos.Count);
//Console.WriteLine("Removendo o Leonardo");

//Console.WriteLine("Posição do Leonardo na lista: " + listaAlunos.Count);

//Console.WriteLine("Removendo todos os alunos da lista");
//listaAlunos.Clear();

List<int> listaGlicemia = new List<int>();
listaGlicemia.Add(136);
listaGlicemia.Add(66);
listaGlicemia.Add(78);
listaGlicemia.Add(236);
listaGlicemia.Add(90);
listaGlicemia.Add(100);
listaGlicemia.Add(111);

listaGlicemia.Sort();

Console.WriteLine(listaGlicemia.Count);
Console.WriteLine(listaGlicemia[0]);
Console.WriteLine(listaGlicemia[listaGlicemia.Count-1]);
