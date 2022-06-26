--Criar tabela Produtos
CREATE TABLE produtos(
    idProduto INT NOT NULL IDENTITY, --auto incremento
    nome VARCHAR(50) NOT NULL,
    preco VARCHAR (50) NOT NULL,
    estoque INT NOT NULL,
    CodEAN INT NOT NULL,
    PRIMARY KEY (idProduto)
);

--Criar tabela Vendas
CREATE TABLE vendas(
    idVendas INT NOT NULL IDENTITY, --auto incremento
    codigoCliente INT NOT NULL,
    valorTotal FLOAT NOT NULL,
    PRIMARY KEY (idVendas),
	CONSTRAINT fk_vendaCliente 
	FOREIGN KEY (codigoCliente) 
	REFERENCES Cliente(idCliente)
);

INSERT into vendas VALUES (2, 5945.00);

SELECT * FROM vendas;

--Criar tabela de Itens Vendidos
CREATE TABLE itensVendidos(
	idItemVenda INT NOT NULL IDENTITY, -- auto incremento
	valorUnitario FLOAT NOT NULL,
	quantidade INT NOT NULL,
	idVendas INT NOT NULL,
	idProduto INT NOT NULL,
	PRIMARY KEY (idItemVenda),
	
	CONSTRAINT fk_itemVenda 
	FOREIGN KEY (idVendas) 
	REFERENCES vendas(idVendas),

	CONSTRAINT fk_produtoVenda FOREIGN KEY (idProduto) REFERENCES produtos(idProduto)
);
select * from vendas


