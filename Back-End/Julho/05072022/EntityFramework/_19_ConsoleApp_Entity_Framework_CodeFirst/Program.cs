
using _19_ConsoleApp_Entity_Framework_CodeFirst;

using (var contexto = new ClienteContext())
{
    Console.WriteLine("Iniciando o programa");
    contexto.Clientes.Add(new Cliente("Leandro","lele@ufn.edu.br"));
    contexto.Clientes.Add(new Cliente("Zacarias", "zacarias@ufn.edu.br"));

    contexto.SaveChanges();


    var quantidade_clientes = contexto.Clientes.Count();
    Console.WriteLine("Quantidade de clientes" + quantidade_clientes);
    //contexto.Clientes.First().Email = "a.zaca@ufn.edu.br";
    //contexto.SaveChanges();
    foreach (var cliente in contexto.Clientes)
    {
        Console.WriteLine("Nome:" + cliente.Nome);
        Console.WriteLine("Email:" + cliente.Email);
        Console.WriteLine("======================");
    }
}
