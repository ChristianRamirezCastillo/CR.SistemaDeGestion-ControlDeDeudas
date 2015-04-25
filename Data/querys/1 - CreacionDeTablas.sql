use dbSistemaGestion 
go
create table tbUsuario
(
	idUsuario		int	not null primary key
	,idNivelAcceso	int
	,idEmpleado		int
	,login			varchar(20)
	,password		varchar(20)
)
go
create table tbNivelAcceso
(
	idNivelAcceso	int not null primary key
	,nivel			varchar(20)
)
go
create table tbEmpleado
(
	idEmpleado		int not null primary key
	,nombres		varchar(50)
	,apellidos		varchar(50)
	,telefono		varchar(10)
	,direccion		varchar(100)
	,distrito		int
	,departamento	int	
	,pais			int
)
go
create table tbCliente
(
	idCliente		int not null primary key
	,idEmpleado		int
	,idBanco		int
	,nombres		varchar(50)
	,apellidos		varchar(50)
	,telefono		varchar(20)
	,direccion		varchar(100)
	,distrito		int
	,departamento	int	
	,pais			int
	,tipoDeudor		int
)
go
create table tbEmpresa
(
	idCliente		int not null primary key
	,nombre			varchar(50)
	,sueldo			decimal(12,2)
	,ruc			int
	,telefono		varchar(20)
	,direccion		varchar(100)
	,distrito		int
	,departamento	int	
	,pais			int
)
go
create table tbBanco
(
	idBanco	int not null primary key
	,nombre	varchar(50)
)
go
create table tbProducto
(
	idProducto		int not null primary key
	,idcliente		int
	,lineaCredito	decimal(12,2)
	,diasMora		int
	,activo			bit
	,tipoMoneda		int
	,deuda			decimal(12,2)
)
go
create table tbGestion
(
	idGestion		int not null primary key
	,idEmpleado		int
	,idCliente		int
	,idProducto		int
	,fecha			datetime
	,descripcion	varchar(500)
	,deudaPagada	decimal(12,2)
	,deudaRestante	decimal(12,2)
)