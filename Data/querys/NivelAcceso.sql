use dbSistemaGestion 
go
create procedure spNivelAcceso_Listar
as
begin
	select
		idNivelAcceso
		,nivel  
	from
		tbNivelAcceso 
end