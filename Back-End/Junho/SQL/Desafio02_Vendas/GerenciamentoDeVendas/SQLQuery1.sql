CREATE DATABASE RhinoStore_DB;
--Utilizar o banco criado
USE RhinoStore_DB;
--Criar tabela Clientes
CREATE TABLE Clientes(
    idCliente INT NOT NULL IDENTITY, --auto incremento
    nome VARCHAR(50) NOT NULL,
    email VARCHAR (50) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    PRIMARY KEY (idCliente)
);

INSERT into Clientes VALUES ('André Zacarias', 'a.andrezacarias@gmail', '011954152815');


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
	REFERENCES Clientes(idCliente)
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

INSERT into Clientes VALUES ('André Zacarias', 'a.andrezacarias@gmail', '011954152815');

INSERT into produtos VALUES ('chinelo', 'R$50,00', 100 ,12365448 );


SELECT *  from Clientes;

SELECT * FROM produtos;