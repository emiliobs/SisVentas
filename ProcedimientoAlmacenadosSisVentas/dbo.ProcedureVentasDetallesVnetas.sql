--Insertar Ventas
create proc spInsertarVentas
@idventa int = null output,
@idcliente int,
@idtrabajador int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(4),
@correlativo varchar(7),
@igv decimal(4,2)
as
insert into  venta (idcliente, idtrabajador,fecha,tipo_comprobante,serie,correlativo, igv)
values(@idcliente, @idtrabajador,@fecha,@tipo_comprobante,@serie,@correlativo, @igv)
--obtenemos el códogp autogenerado:
set @idventa = @@IDENTITY
go

--Eliminar Ventas:
create proc soEliminarVentas
@idventa int
as 
delete from venta
where idventa = @idventa
go

--Insertar los detalles de ventas:
create proc spInsertarDetalleVenta
@iddetalle_venta int output,
@idventa int,
@iddetalle_ingreso int,
@cantidad int,
@precio_venta money,
@descuento money
as
insert into detalle_venta (idventa, iddetalle_ingreso, cantidad, precio_venta, descuento)
values(@idventa, @iddetalle_ingreso, @cantidad, @precio_venta, @descuento)
go