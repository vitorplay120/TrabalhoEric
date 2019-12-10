select * from equipamentos;

CREATE PROCEDURE ExcluirEquipamentoPorId
(
	@equipamentosId int 
)

as 

begin
	Delete From equipamentos where equipamentosId = @equipamentosId
end

exec ExcluirEquipamentoPorId @equipamentosId = 1


CREATE PROCEDURE AtualizarEquipamento
(
	@equipamentosId int,
	@equipamento nvarchar(50), 
	@cnpj int,
	@tipo nvarchar(10),
	@nome nvarchar(100),
	@logradouro nvarchar(100),
	@qsa nvarchar(100)
)

as 

begin

Update equipamentos
set equipamento = @equipamento, cnpj = @cnpj, tipo = @tipo, nome = @nome, logradouro = @logradouro, qsa = @qsa
where equipamentosId = @equipamentosId

end

CREATE PROCEDURE IncluirEquipamento
(
	@equipamentosId int,
	@equipamento nvarchar(50), 
	@cnpj int,
	@tipo nvarchar(10),
	@nome nvarchar(100),
	@logradouro nvarchar(100),
	@qsa nvarchar(100)
)

as

begin
	Insert into equipamentos values (@equipamento, @cnpj, @tipo, @nome, @logradouro, @qsa) 
end


CREATE PROCEDURE ObterEquipamento

as 

begin
	Select equipamentosId, equipamento, cnpj, tipo, nome, logradouro, qsa from equipamentos;
end