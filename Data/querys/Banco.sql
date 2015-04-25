use dbSistemaGestion
go
create procedure spBanco_ListarCombo
as
begin
	select 
		idBanco 
		,nombre 
	from
		tbBanco 
end