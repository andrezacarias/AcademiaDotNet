using CodeFirst_relacionamentoObjetos;

class Program
{
    static void Main(string[] args)
    {
        //string nome = "LX";
        //Modelo tmp = new Modelo() { Nome = nome };
        //tmp.Salvar();

        //var listaModelos = Modelo.Todos();

        //foreach(var item in listaModelos)
        //{
        //    Console.WriteLine(item.Id);
        //    Console.WriteLine(item.Nome);
        //}

        //var primeiroModelo = listaModelos.First();

        //Veiculo tmp2 = new Veiculo() { Nome = "Honda", Modelo = primeiroModelo, Ano = 2004 };
        //tmp2.Salvar();


        //Console.WriteLine("Total de Modelos: " + Modelo.Todos().Count);
        //foreach (var item in Modelo.Todos())
        //{
        //    Console.WriteLine(item.Id);
        //    Console.WriteLine(item.Nome);
        //}

        //BaseContext contexto = new BaseContext();
        //var resultado = contexto.Modelos.Where(modelo => modelo.Id ==1).ToList();
        //while (resultado.Count > 0)
        //{
        //    contexto.Modelos.Remove(resultado[1]);
        //    contexto.SaveChanges();
        //}

        //Console.WriteLine("Lista de Veiculos");
        //foreach (var item in Veiculo.Todos())
        //{
        //    Console.WriteLine(item.Id);
        //    Console.WriteLine(item.Nome);
        //    Console.WriteLine(item.Ano);
        //    Console.WriteLine(item.Modelo.Nome);
        //}
        //Modelo meuModelo = Modelo.Todos().First();
        //meuModelo.Remover();
        //
        BaseContext contexto = new BaseContext();
        var resultado = contexto.Modelos.Where(n => n.Nome.Contains("LX")).ToList();
        Console.WriteLine(resultado[0].Id);
        Console.WriteLine(resultado[1].Nome);
        contexto.Modelos.Remove(resultado[0]);
           
        contexto.SaveChanges();

        Console.WriteLine("Total de modelos: " + Modelo.Todos().Count);

    }

   
   
}




