use dbSistemaGestion 
go
alter table [dbo].[tbUsuario] add constraint FK_Usuario_NivelAcceso foreign key([idNivelAcceso]) references [dbo].[tbNivelAcceso]([idNivelAcceso])
alter table [dbo].[tbUsuario] add constraint FK_Usuario_Empleado foreign key([idEmpleado]) references [dbo].[tbEmpleado]([idEmpleado])
go
alter table [dbo].[tbProducto] add constraint FK_Producto_Cliente foreign key ([idcliente]) references [dbo].[tbCliente]([idcliente])
go
alter table [dbo].[tbGestion] add constraint FK_Gestion_Empleado foreign key ([idEmpleado]) references [dbo].[tbEmpleado]([idEmpleado])
alter table [dbo].[tbGestion] add constraint FK_Gestion_Cliente foreign key ([idCliente]) references [dbo].[tbCliente]([idCliente])
alter table [dbo].[tbGestion] add constraint FK_Gestion_Producto foreign key ([idProducto]) references [dbo].[tbProducto]([idProducto])
go
alter table [dbo].[tbCliente] add constraint FK_Cliente_Banco foreign key ([idBanco]) references [dbo].[tbBanco]([idBanco])
alter table [dbo].[tbCliente] add constraint FK_Cliente_Empleado foreign key ([idEmpleado]) references [dbo].[tbEmpleado]([idEmpleado])
go
alter table [dbo].[tbEmpresa] add constraint FK_Cliente_Empresa foreign key ([idCliente]) references [dbo].[tbCliente]([idCliente])