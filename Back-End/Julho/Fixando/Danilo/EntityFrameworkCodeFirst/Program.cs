using EntityFrameworkCodeFirst;

using (var context = new ClienteContext())
{
    var quantidade_clientes = context.Clientes.Count();
    //context.Clientes.Add(new Cliente() { Nome = "André Z", Telefone = "11954152815", CPF = "194875326" });
    //context.Produtos.Add(new Produto() { Nome = "Camera Yashica", Descricao = "Vintage" });
    //context.SaveChanges();

    var query = context.Clientes.Where(c=> c.Nome.Contains("nd")).ToString();
    var clientes = context.Clientes.Where(c => c.Nome.Contains("nd")).ToList();

}