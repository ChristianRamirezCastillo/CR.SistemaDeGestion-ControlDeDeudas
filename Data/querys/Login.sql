use dbSistemaGestion 
go
create procedure spLogin_ValidarUsuario
(
	@login varchar(20)
)
as
begin
	select 
		(1)
	from
		[dbo].[tbUsuario]
	where
		login = @login
end
go
go
create procedure spLogin_ValidarPassword
(
	@login varchar(20)
	,@password varchar(20)
)
as
begin
	select
		(1) 
	from
		[dbo].[tbUsuario]
	where 
		login = @login 
	and
		password = @password
end
go
go
alter procedure spLogin_DatosUsuario
(
	@login varchar(20)
	,@password varchar(20)
)
as
begin
	select 
		u.idUsuario
		,u.login
		,na.nivel
		,e.nombres
		,e.apellidos
		,e.idEmpleado 
	from
		tbUsuario u 
		inner join	tbNivelAcceso na	on u.idNivelAcceso = na.idNivelAcceso
		inner join	tbEmpleado e		on e.idEmpleado = u.idEmpleado
	where 
		u.login = @login 
	and
		u.password = @password
end