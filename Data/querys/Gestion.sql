use dbSistemaGestion 
go
alter procedure spGeston_Listar
(
	@idEmpleado varchar(20) = null
	,@idCliente varchar(20) = null
)
as
begin
	select
		g.idGestion 
		,g.idEmpleado
		,g.idCliente 
		,g.idProducto 
		,e.nombres + ' ' + e.apellidos as Empleado
		,convert(varchar, g.fecha, 103)as Fecha 
		,right(convert(varchar, g.fecha, 100),8) as Hora 
		,p.deuda as Deuda
		,g.deudaPagada as Pago
		,g.deudaRestante as Resta
		,g.descripcion
	from
		tbGestion g 
	inner join 
		tbProducto p on g.idProducto = p.idProducto
	inner join 
		tbEmpleado e on g.idEmpleado = e.idEmpleado 
	where 
		(g.idEmpleado = @idEmpleado or @idEmpleado is null)
	and
		(g.idCliente = @idCliente or @idCliente is null)
	order by 
		g.fecha desc
end
go
go
alter procedure spGestion_ListarUltimaFecha
(
	@idCliente as int
)
as
begin
	select
		max( convert(varchar, fecha, 103) + right(convert(varchar, fecha, 100),8) ) as fecha
	from
		tbGestion 
	where 
		idCliente = @idCliente 
end
go
go
alter procedure spGestion_Agregar
(
	
	@idEmpleado int 
	,@idCliente  int 
	,@idProducto int
	,@descripcion varchar(500)
	,@deudaPagada decimal(12,2)
	,@deudaRestante decimal(12,2)
	
	,@tipoDeudor int
)
as
begin transaction

	begin try
		
		/*Se agrega nueva gestion*/
		declare @idGestion int
		set @idGestion = (select isnull(max(idGestion), 0) + 1 from tbGestion)

		insert into 
			tbGestion 
		values
			(@idGestion, @idEmpleado, @idCliente, @idProducto, GETDATE(), @descripcion, @deudaPagada, @deudaRestante)

		
		/*Se actualiza el tipo deudor dependiendo del tipo de gestion*/
		update 
			 tbCliente 
		set
			tipoDeudor = @tipoDeudor
		where 
			idCliente = @idCliente
		
		/*Se confirma la transaccion*/
		commit transaction

	end try
	begin catch

		rollback transaction

	end catch
	
	
