--Disminuir el stock después de una venta:
create proc spDisminuirStock
@iddetalle_ingreso int,
@cantidad int
as
update detalle_ingreso set stock_actual = stock_actual -@cantidad
where iddetalle_ingreso = @iddetalle_ingreso
go