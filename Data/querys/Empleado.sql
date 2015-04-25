use dbSistemaGestion 
go
create procedure spEmpleado_ListarCombo
as
begin
	select
		idEmpleado
		,nombres + ' ' + apellidos  
	from
		tbEmpleado  
end
go
go
create procedure spEmpleado_Listar
as
begin
	select
		idEmpleado as ID
		,nombres as Nombres
		,apellidos as Apellidos
		,telefono as Teléfono
		,direccion as Dirección
		,distrito as idDistrito
		,departamento as idDepartamento
		,pais as idPais
	from
		tbEmpleado
end
go
go
create procedure spEmpleado_Agregar
(
	@nombres varchar(50)
	,@apellidos varchar(50)
	,@telefono varchar(10)
	,@direccion varchar(100)
	,@distrito int
	,@departamento int
	,@pais int
)
as
begin
	declare @idEmpleado int = (select isnull(max(idEmpleado),0) + 1 from tbEmpleado)

	insert into 
		[dbo].[tbEmpleado]
	values
		(@idEmpleado, @nombres, @apellidos, @telefono, @direccion, @distrito, @departamento, @pais)
end
go
go
create procedure spEmpleado_Editar
(
	@idEmpleado int
	,@nombres varchar(50)
	,@apellidos varchar(50)
	,@telefono varchar(10)
	,@direccion varchar(100)
	,@distrito int
	,@departamento int
	,@pais int
)
as
begin
	update 
		tbEmpleado
	set
		nombres = @nombres 
		,apellidos = @apellidos 
		,telefono = @telefono 
		,direccion = @direccion 
		,distrito = @distrito 
		,departamento = @departamento 
		,pais = @pais 
	where
		[idEmpleado] =  @idEmpleado
end
go
go
create procedure spEmpleado_Borrar
(
	@idEmpleado int
)
as
begin
	delete  
		tbEmpleado 
	where
		idEmpleado = @idEmpleado 
end
go
go
create procedure spEmpleado_Buscar
(
	@nombres varchar(50) = null
	,@apellidos varchar(50) = null
	
)
as
begin
	select
		idEmpleado as ID
		,nombres as Nombres
		,apellidos as Apellidos
		,telefono as Teléfono
		,direccion as Dirección
		,distrito as idDistrito
		,departamento as idDepartamento
		,pais as idPais
	from
		tbEmpleado
	where
		(nombres like @nombres + '%' or @nombres is null)
	and	
		(apellidos like @apellidos + '%' or @apellidos is null)
end
