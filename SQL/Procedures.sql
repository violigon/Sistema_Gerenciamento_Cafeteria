	drop proc BuscarCliente

	create procedure BuscarCliente
	@Nome nvarchar
	as
	begin
	
	select * from TBClientes where Nome_Completo like  @Nome+ '%' and status = 1 and Cod_Cliente > 1
	end
	------------------------------------------------------------

	
	drop proc BuscarFunc
	create procedure BuscarFunc
	@Nome nvarchar
	as
	begin
	
	select * from TBFuncionarios where Nome_Completo like @Nome + '%' and status = 1
	end
	----------------------------------------------------------------
	drop proc BuscarFornec
	create procedure BuscarFornec
	@Nome nvarchar
	as
	begin
	
	select * from TBFornecedor where Nome_Fantasia like @Nome + '%' and status = 1
	end
	----------------------------------------------------------------

	drop proc BuscarProd
	create procedure BuscarProd
	@Nome nvarchar
	as
	begin
	
	select * from TBProdutos where Nome_Produto like @Nome + '%' and status = 1
	end


	drop proc BuscarUsuario
	create procedure BuscarUsuario
	@Nome nvarchar
	as
	begin
	
	select * from TB_Login where LoginUser like @Nome + '%' and status = 1
	end


	----------------------------------------------------------------
	  drop proc BuscarProdIN

  create procedure BuscarProdIN
	@Nome nvarchar
	as
	begin
	
	select * from TBProdutos where Nome_Produto like @Nome + '%' and Tipo_Produto = 'IN' and status = 1
	end
   ----------------------------------------------------------------
  
  drop proc BuscarProdPA
  create procedure BuscarProdPA
	@Nome nvarchar
	as
	begin
	
	select *, ROUND(Custo,2) from TBProdutos where Nome_Produto like @Nome + '%' and Tipo_Produto = 'PA' and status = 1
	end
----------------------------------------------------------------

drop proc BuscarEst
  create procedure BuscarEst
	@Nome nvarchar
	as
	begin
	
	select * from TBEstrutura where Nome_Est like @Nome + '%'
	end
----------------------------------------------------------------
  create procedure BuscarProdCompra
	@Cod nvarchar
	as
	begin
	
	select * from TBItens_Compras where Cod_Produto like @Cod + '%'
	end
	----------------------------------------------------------------
	create procedure BuscarUser
	@Nome nvarchar
	as
	begin
	
	select * from TB_Login where LoginUser like @Nome + '%'
	end