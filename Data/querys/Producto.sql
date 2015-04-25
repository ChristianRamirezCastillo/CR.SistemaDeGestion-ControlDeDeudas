use dbSistemaGestion
go
go
create procedure spProducto_ListarDeuda
(
	@idProducto as int
)
as
begin
	select 
		deuda
	from
		tbProducto
	where 
		idProducto = @idProducto
end
