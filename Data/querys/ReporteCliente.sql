use dbSistemaGestion
go
go
alter procedure spReporteCliente_Listar
(
	@banco varchar(25) = null
	,@empleado varchar(50) = null
)
as
begin
	select 
		c.idEmpleado 
		,c.idBanco 
		,b.nombre						
		,e.nombres + ' ' + e.apellidos	as [Empleado]	
		,c.idCliente					
		,c.nombres						
		,c.apellidos					
		,isnull(c.telefono,0)			as [Telefono]		
		,c.direccion					
		,c.distrito						as [idDistrito]
		,c.departamento					as [idDepartamento]
		,c.pais							as [idPais]
		,case c.tipodeudor
			when 0 then 'SinGestion'
			when 1 then 'Cobrado'
			when 2 then 'Inubicable'
			when 3 then 'PromesaPendiente'
			when 4 then 'NoCobrado'
		end								as [tipodeudor]
	from
		tbCliente c
	inner join
		tbEmpleado e on c.idEmpleado = e.idEmpleado 
	inner join
		tbBanco b on c.idBanco = b.idBanco
	where
		(b.nombre  like @banco + '%' or @banco is null)
	and
		(e.nombres + ' ' + e.apellidos like @empleado + '%' or @empleado is null)
end

