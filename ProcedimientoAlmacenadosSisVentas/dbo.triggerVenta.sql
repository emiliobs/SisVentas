--Reestablecer el Stock despúes de eliminar la venta y sus detalles:
create trigger trRestablecerStock
on [detalle_venta]
for delete
as
update di set di.stock_actual = di.stock_actual + dv.cantidad
from detalle_ingreso as di inner join deleted as dv on di.iddetalle_ingreso = dv.iddetalle_ingreso
go
go