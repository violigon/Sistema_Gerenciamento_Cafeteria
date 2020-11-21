--drop database BDMaisCafe
Create Database BDMaisCafe
use BDMaisCafe

-------------------------------------------------------------------------
SET DATEFORMAT DMY
-------------------------------------------------------------------------

Create Table TBClientes
(
Cod_Cliente int NOT NULL Primary Key,
Nome_Completo varchar (100) NOT NULL,
CPF varchar(11),
Sexo varchar(1) CHECK (Sexo IN ('F','M')),
Data_de_Nascimento date,
Email varchar (50),
status bit
)


Create Table TBFornecedor
(
Cod_Fornecedor int NOT NULL Primary Key,
CNPJ varchar(14) NOT NULL,
Nome_Fantasia varchar (40) NOT NULL,
Razão_Social varchar (60),
Telefone varchar(10),
Email varchar (50),
CEP varchar(8),
Logradouro varchar (40),
Cidade varchar (50),
Bairro varchar (50),
Numero varchar(4),
UF char (2),
Site_Empresa varchar (50),
status bit
)

Create Table TBFuncionarios
(
Cod_Funcionario int  NOT NULL Primary Key,
Nome_Completo varchar (100) NOT NULL,
Data_Nascimento date,
Sexo  varchar(1) CHECK (Sexo IN ('F','M')),
CPF varchar(11) NOT NULL,
RG varchar(9),
Telefone varchar(10),
Logradouro varchar (100),
Numero varchar(4),
CEP varchar(8) NOT NULL,
Cidade varchar (100),
Bairro varchar (100),
UF varchar (2),
status bit,
)


Create Table TBNivelAcesso
(
CodAcesso char (1) Primary Key,
Tipo varchar (10),
)

Create table TB_Login
(
Cod_login int NOT NULL Primary Key,
LoginUser varchar (15),
Senha varchar (15),
CodAcesso char (1),
Cod_Funcionario int,
status bit,
Constraint FK_CodAcesso Foreign Key (CodAcesso) references TBNivelAcesso (CodAcesso),
Constraint FK_Cod_Funcionario Foreign Key (Cod_Funcionario) references TBFuncionarios (Cod_Funcionario)
)




drop table TBProdutos
Create Table TBProdutos (
Cod_Produto int NOT NULL Primary Key,
Nome_Produto varchar (40) NOT NULL,
Tipo_Produto varchar (2) NOT NULL,
Unidade varchar (10) NOT NULL,
status bit,
Custo smallmoney,
preço_venda smallmoney,
Quantidade decimal(5,4),
)
alter table TBProdutos
add  Quantidade decimal(10,8)

Create Table TBCompras(
Cod_Compra int NOT NULL Primary Key,
Cod_Fornecedor int NOT NULL,
Data_Emissao date NOT NULL,
Data_Pgto date,
Data_Inclusao date default getdate(),
)


Create Table TBItens_Compras(
Cod_Item int NOT NULL,
Cod_Compra int NOT NULL,
Cod_Produto int NOT NULL,
Valor money NOT NULL,
Quantidade decimal(5,4)
Constraint pk_TBItens_Compras primary key (Cod_Compra, Cod_Item)

) 

alter table TBItens_Compras
add Quantidade decimal(10,9)

alter table TBItens_Compras
drop column Quantidade decimal(5,4)


Create Table TBContas_a_Pagar
(
Cod_Titulo int identity NOT NULL Primary Key,
Cod_Compra int,
Descrição varchar(40),
Valor Money NOT NULL,
Vencimento date,
Data_Pagamento date,
Saldo money,
)


Create Table TBCaixa(
Cod_Caixa int identity NOT NULL Primary Key,
Tipo varchar(1) CHECK (Tipo IN ('E','S')), --Entrada ou Saída
Cod_Movimento int,
Valor money NOT NULL
)

Create table TBVendas(
Cod_Venda int NOT NULL primary key,
Cod_Cliente int NOT NULL,
Data_Venda date default getdate(),
Forma_Pagamento varchar(10),
CPF varchar(11),
Usuario varchar(40)
)

alter table TBVendas
add Usuario varchar(40)

Create table TBItens_Vendas(
Cod_Venda int NOT NULL,
Cod_Item int NOT NULL,
Cod_Produto int NOT NULL, 
Quantidade int NOT NULL,
Valor money NOT NULL,
Custo money NOT NULL,
Constraint pk_TBItens_Vendas primary key (Cod_Venda, Cod_Item)
)

Create Table TBEstrutura(
Cod_Est int NOT NULL ,
Nome_Est varchar(40) NOT NULL,
Cod_ProdIN int NOT NULL,
--Nome_ProdIN varchar(40),
Quantidade decimal (5,4),
Cod_ProdPA int
Constraint pk_TBEstrutura primary key (Cod_Est, Cod_ProdIN)
)

Create Table TBMov_Estoque(
Cod_Estoque int identity NOT NULL Primary key,
Cod_Produto int NOT NULL,
Quantidade int NOT NULL
)




-------------------------------------------------------------------------------------------------------------------------
 
  
 go
 Alter Table TBCompras
  Add Constraint FKCod_Fornec_CO  Foreign Key (Cod_Fornecedor) references TBFornecedor (Cod_Fornecedor)
      
 go
  Alter Table TBItens_Compras
  Add Constraint FKCod_Compra_IC  Foreign Key (Cod_Compra) references TBCompras (Cod_Compra)

 go
  Alter Table TBItens_Compras
  Add Constraint FKCod_Prod_IC  Foreign Key (Cod_Produto) references TBProdutos (Cod_Produto)

  go
 Alter Table  TBContas_a_Pagar
 Add Constraint FKCod_Compra_CP Foreign Key(Cod_Compra)references TBCompras (Cod_Compra)

  go
 Alter Table TBVendas
 Add Constraint FKCod_Cliente_V Foreign Key (Cod_Cliente) references TBClientes (Cod_Cliente)
 
 go
 Alter Table TBItens_Vendas
 Add Constraint FKCod_Venda_IV Foreign Key(Cod_Venda)references TBVendas (Cod_Venda)

  go
 Alter Table TBItens_Vendas
 Add Constraint FKCod_Prod_IV Foreign Key(Cod_Produto)references TBProdutos(Cod_Produto)

 go
 Alter Table TBMov_Estoque
 Add Constraint FKCod_Prod_Es Foreign Key (Cod_Produto) references TBProdutos (Cod_Produto)




 


 /* 

  go
 Alter Table TBVendas
 Add Constraint FKCod_Item_Venda Foreign Key (Cod_Item_Venda) references TBItens_Vendas (Cod_Item_Venda)
 */
 -------------------------------------------------------------------------------------------------------------------------
  insert into TBClientes(Nome_Completo) values('Ana Caroline')
   go
  set identity_insert TBCompras ON
  go

  select * from TBEstrutura

  sp_help TB_Login
  insert into TB_Login(Cod_login, LoginUser, Senha, CodAcesso, Cod_Funcionario) values(1, 'Ana', 123, 2, 1)
   dbcc checkident(TB_Login, reseed, 0)
   
   go
  set identity_insert TBItens_Vendas ON
  go

  delete from TB_Login


 set identity_insert TBFuncionarios on
  go
    insert into TBFuncionarios (Cod_Funcionario,Nome_Completo, CPF, CEP) values(1, 'Hudson', 44834190803, 00000001)

	select * from TBFuncionarios

 set identity_insert TBFuncionarios on
  go
      insert into TBFornecedor(CNPJ, Nome_Fantasia, Razão_Social, CEP) values(60409075000152, 'Nestlé','Nestlé Brasil LTDA',04571010)

	  select * from TBFornecedor


set identity_insert TBProdutos on
  go
      insert into TBProdutos(Nome_Produto, Tipo_Produto, Unidade, Custo) values('Café Forte','IN','Kg', 6.00)
	  insert into TBProdutos(Nome_Produto, Tipo_Produto, Unidade, Custo) values('Café Fraco','IN','Kg', 5.00)

select * from TBProdutos


 /*drop proc SP_Insert_Clientes
 Create proc SP_Insert_Clientes
  as
   begin
	Insert into TB_Clientes values('Luísa de Sousa','luisa.sousa@gmail.com', 41332456, 987667654, 407876544, 33423298765, 'F', '23/05/1970', 'Rua Esmeralda, 58',06978400, 'Jd das Flores', 'Barueri', 'SP')
	Insert into TB_Clientes values('Fernanda Guimarães','fe.gui@gmail.com', 44565456, 983454324, 498776544, 36765898765, 'F', '15/10/1965', 'Rua Comprida, 1345',06678350, 'Parque dos Camargos', 'Barueri', 'SP')
	Insert into TB_Clientes values('Guilherme de Almeida','lhermegui@gmail.com', 31334554, 954436678, 456766898, 09877654567, 'M', '10/07/1956', 'Rua Legal, 433',06565400, 'Jardim Mutinga', 'Osasco', 'SP')
  End
  exec SP_Insert_Clientes
  
  drop proc SP_Select_Clientes
  Create proc SP_Select_Clientes
   as
    begin
     Select * from TB_Clientes
   End
   
   exec SP_Select_Clientes
   */

   select * from TBClientes

   dbcc checkident(TBClientes, reseed, 0)
    Delete TBClientes

	delete from TBClientes



	Create