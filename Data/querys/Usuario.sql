use dbSistemaGestion 
go
create procedure spUsuario_Agregar
(
	@idNivelAcceso int
	,@idEmpleado int
	,@login varchar(20)
	,@password varchar(20)
)
as
begin
	declare @idUsuario int = (select isnull(max(idUsuario),0) + 1 from tbUsuario)

	insert into 
		[dbo].[tbUsuario]
	values
		(@idUsuario, @idNivelAcceso, @idEmpleado, @login, @password)
end
go
go
create procedure spUsuario_Editar
(
	@idUsuario int
	,@idNivelAcceso int
	,@idEmpleado int
	,@login varchar(20)
	,@password varchar(20)
)
as
begin
	update 
		[dbo].[tbUsuario]
	set
		idNivelAcceso = @idNivelAcceso
		,idEmpleado = @idEmpleado
		,login = @login
		,password = @password
	where
		idUsuario = @idUsuario 
end
go
go
create procedure spUsuario_Borrar
(
	@idUsuario int
)
as
begin
	delete  
		[dbo].[tbUsuario]
	where
		idUsuario = @idUsuario 
end
go
go
create procedure spUsuario_Listar
as
begin
	select
		u.idUsuario as ID
		,u.login as Login
		,na.nivel
		,e.nombres + ' ' + e.apellidos as Empleado
		,u.idNivelAcceso
		,u.idEmpleado
	from
		tbUsuario u 
	inner join	tbNivelAcceso na	on u.idNivelAcceso = na.idNivelAcceso
	inner join	tbEmpleado e		on u.idEmpleado = e.idEmpleado
end
go
go
create procedure spUsuario_Buscar
(
	@login varchar(20) = null
	,@nivelAcceso varchar(20) = null
	,@empleado varchar(50) = null
	
)
as
begin
	select
		u.idUsuario as ID
		,u.login as Login
		,na.nivel
		,e.nombres + ' ' + e.apellidos as Empleado
		,u.idNivelAcceso
		,u.idEmpleado
	from
		tbUsuario u 
	inner join	tbNivelAcceso na	on u.idNivelAcceso = na.idNivelAcceso
	inner join	tbEmpleado e		on u.idEmpleado = e.idEmpleado
	where
		(u.login like @login + '%' or @login is null)
	and	
		(na.nivel like @nivelAcceso + '%' or @nivelAcceso is null)
	and  
		((e.nombres + ' ' + e.apellidos) like + @empleado +'%' or @empleado is null)
end
