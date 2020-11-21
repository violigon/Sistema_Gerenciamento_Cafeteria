DROP view RelVendas
create view RelVendas
as (SELECT Cod_Venda, Cod_Item, TBItens_Vendas.Cod_Produto, TBProdutos.Nome_Produto collate database_default as Nome_Produto,TBItens_Vendas.Custo, TBItens_Vendas.Quantidade, Valor
	FROM TBItens_Vendas inner join TBProdutos 
	on TBProdutos.Cod_Produto = TBItens_Vendas.Cod_Produto)

select * from RelVendas

create view RelProd
as(select * from TBProdutos where status = 1)


update TBProdutos set Quantidade = 0 where Cod_Produto = 3
select * from TBMov_Estoque

create view PesqProdCompras
as (SELECT Prod.Cod_Produto, Nome_Produto, Tipo_Produto, Unidade, Custo, preço_venda, Prod.Quantidade 
	FROM TBProdutos Prod left join TBEstrutura Est 
	on Prod.Cod_Produto = Est.Cod_ProdPA 
	where Cod_Est is null)

create view RelCompras
as( SELECT Cod_Compra, Cod_Item, I.Cod_Produto, Nome_Produto, I.Quantidade, Valor  FROM TBItens_Compras I INNER JOIN TBProdutos P 
	on I.Cod_Produto = P.Cod_Produto 
)

update TBItens_Compras set Quantidade = 5
SELECT * FROM TBCompras
select * from TBItens_Compras

select * from RelCompras