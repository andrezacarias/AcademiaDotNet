public class Cliente
{
    public string codCliente, nome, rua, numero, complemento, cep, cidade, estado, fone;
}

public class Vendedor
{
    public string codVendedor, nome, fone, senha;
}

public class Prateleira
{
    public string codPrateleira, localizacao;
}

public class Produto
{
    public string codProduto, codigoBarras, descricao, codPrateleira;
}

public class Venda
{
    public string dataNotaFiscal, numeroNotaFiscal, codProduto, codVendedor, codCliente;

}

