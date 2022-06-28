CREATE DATABASE RhinoStore_DB;
--Utilizar o banco criado
USE RhinoStore_DB;
--criando tabela Cliente
CREATE TABLE Cliente (
  idCliente INT IDENTITY
  PRIMARY KEY NOT NULL,
  nomeCompleto VARCHAR(150) NOT NULL,
  email VARCHAR (50) NOT NULL,
  cpf VARCHAR(14) NOT NULL,
  celular VARCHAR(20) NOT NULL,      
);
--criando tabela Produto
CREATE TABLE Produto (
  idProduto INT PRIMARY KEY NOT NULL,
  descricao VARCHAR(50) NOT NULL,
  categoria VARCHAR(50) NOT NULL,
  codEAN VARCHAR(50) NOT NULL,
  preco FLOAT NOT NULL,
  estoque INT NOT NULL,   
);
--criando tabela Venda
CREATE TABLE Venda (
idVenda INT PRIMARY KEY NOT NULL,
valorTotal FLOAT NOT NULL,
Cliente_idCliente INT NOT NULL,
ItemVenda_idItemVenda INT NOT NULL,
CONSTRAINT fk_Cliente_Venda
FOREIGN KEY (Cliente_idCliente)
REFERENCES Cliente (idCliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
CONSTRAINT fk_ItemVenda_Venda
FOREIGN KEY (ItemVenda_idItemVenda)
REFERENCES ItemVenda (idItemVenda)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);
--criando tabela ItemVenda
CREATE TABLE ItemVenda (
idItemVenda INT PRIMARY KEY NOT NULL,
Venda_idVenda INT NOT NULL,
Produto_idProduto INT NOT NULL,
quantidade INT NOT NULL,
valorTotal FLOAT NOT NULL,
CONSTRAINT fk_Venda_ItemVenda
FOREIGN KEY (Venda_idVenda)
REFERENCES Venda (idVenda)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
CONSTRAINT fk_Produto_ItemVenda
FOREIGN KEY (Produto_idProduto)
REFERENCES Produto (idProduto)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);
INSERT into Cliente VALUES ('André Zacarias', 'a.andrezacarias@gmail','19488832587', '011954152815');

SELECT * FROM Cliente;