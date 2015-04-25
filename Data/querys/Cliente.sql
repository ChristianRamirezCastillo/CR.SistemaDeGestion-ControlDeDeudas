use dbSistemaGestion 
go
alter procedure spCliente_Listar
(
	@idBanco int = null
	,@idEmpleado int = null
)
as
begin
	select
		c.idEmpleado 
		,c.idBanco 
		,b.nombre as Banco
		,e.nombres + ' ' + e.apellidos as Empleado
		,c.idCliente	as [N° Doc]
		,c.nombres as Nombres
		,c.apellidos as Apellidos
		,c.telefono as Teléfono
		,c.direccion as Dirección
		,c.distrito as idDistrito
		,c.departamento as idDepartamento
		,c.pais as idPais
		,c.tipoDeudor idTipoDuedor
	from
		tbCliente c
	inner join 
		tbEmpleado e	on c.idEmpleado = e.idEmpleado 
	inner join
		tbBanco b		on c.idBanco = b.idBanco 
	where
		(c.idBanco = @idBanco or @idBanco is null) 
	and	
		(c.idEmpleado = @idEmpleado or @idEmpleado is null)
end
go
go
alter procedure spCliente_Buscar
(
	@idBanco int = null
	,@idEmpleado varchar(20) = null
	,@idCliente varchar(15) = null
	,@nombres varchar(50) = null
	,@apellidos varchar(50) = null
	,@empleado varchar(50) = null
)
as
begin
	select
		c.idEmpleado 
		,c.idBanco 
		,b.nombre as Banco
		,e.nombres + ' ' + e.apellidos as Empleado
		,c.idCliente	as [N° Doc]
		,c.nombres as Nombres
		,c.apellidos as Apellidos
		,c.telefono as Teléfono
		,c.direccion as Dirección
		,c.distrito as idDistrito
		,c.departamento as idDepartamento
		,c.pais as idPais
		,c.tipoDeudor idTipoDuedor
	from
		tbCliente c
	inner join 
		tbEmpleado e	on c.idEmpleado = e.idEmpleado 
	inner join
		tbBanco b		on c.idBanco = b.idBanco 
	where
		(c.idBanco = @idBanco or @idBanco is null) 
	and	
		(c.idEmpleado = @idEmpleado or @idEmpleado is null)
	and
		(c.idCliente like  @idCliente + '%' or @idCliente is null)
	and
		(c.nombres like @nombres + '%' or @nombres is null)
	and
		(c.apellidos like @apellidos + '%' or @apellidos is null)
	and
		(e.nombres + ' ' + e.apellidos like @empleado + '%' or @empleado is null)
end
go
go
alter procedure spCliente_ListarProducto
(
	@idCliente int = null
	,@activo bit = null
)
as 
begin
	select
		idProducto
		,idcliente 
		,lineaCredito as [Linea de Crédito]
		,diasMora as [Dias Mora]
		,activo as Activo
		,tipoMoneda as idTipoMoneda
		,deuda as Deuda
	from
		tbProducto 
	where 
		(idcliente = @idCliente or @idCliente is null)
	and
		(activo = @activo or @activo is null)
end
go
go
create procedure spCliente_ListarEmpresa
(
	@idCliente as int 
)
as
begin
	select
		idCliente 
		,nombre 
		,sueldo 
		,ruc 
		,telefono 
		,direccion 
		,distrito as idDistrito
		,departamento as idDepartamento
		,pais as idPais
	from 
		tbEmpresa 
	where 
		idCliente = @idCliente
end
