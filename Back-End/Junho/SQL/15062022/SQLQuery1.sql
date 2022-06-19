/*create database ATOSUFN;
			string nome;
			int idade;
			string cpf;
			string end;
			string bairro;
			string cidade;
			string cep;
*/

use ATOSUFN;

create table PESSOA(
id integer primary key not null identity,
nome varchar(50),
idade integer,
cpf varchar(20),
ende varchar(100),
bairro varchar(50),
cep varchar(10),
cidade varchar(50),
)

insert into PESSOA values('Alexandre Brzoski', 18, '12345678910', 'Rua Antares 166', 'Santa Bárbara', '08340-092',
'São Paulo');

select * from PESSOA;

insert into PESSOA values('Rafael Brzoski', 10, '12345678911', 'Rua Antares 166', 'Santa Bárbara', '08340-092',
'São Paulo');

select * from INFORMATION_SCHEMA.TABLES;

select * from INFORMATION_SCHEMA.COLUMNS;

select nome, cpf from PESSOA;
