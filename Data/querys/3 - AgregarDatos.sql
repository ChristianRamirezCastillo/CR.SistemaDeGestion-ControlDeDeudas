use dbSistemaGestion 
go
insert into [dbo].[tbNivelAcceso] values(1, 'Administrador')
insert into [dbo].[tbNivelAcceso] values(2, 'Gestor')
select * from [dbo].[tbNivelAcceso]
go
go
insert into [dbo].[tbEmpleado]([idEmpleado], [nombres], [apellidos]) values(1, 'Christian', 'Ramirez')
insert into [dbo].[tbEmpleado]([idEmpleado], [nombres], [apellidos]) values(2, 'Angie', 'Caceres')
select * from  [dbo].[tbEmpleado]
go
go
insert into [dbo].[tbUsuario] values(1,1,1,'cramirez','123')
insert into [dbo].[tbUsuario] values(2,2,2,'acaceres','123')
select * from [dbo].[tbUsuario]
go
go
insert into [dbo].[tbBanco] values (1, 'Banco BCP')
insert into [dbo].[tbBanco] values (2, 'Banco BBVA')
insert into [dbo].[tbBanco] values (3, 'Banco Interbank')
select * from tbBanco 