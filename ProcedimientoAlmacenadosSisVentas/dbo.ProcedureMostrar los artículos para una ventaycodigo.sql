--Mostrar los artículos para una venta:
create proc spBuscarArticuloVentaNombre
@txtBuscar varchar(50)
as
select d.iddetalle_ingreso, a.codigo,a.nombre,c.nombre as Categoria,p.nombre as Presentacion,
d.stock_actual,d.precio_compra,d.precio_venta,d.fecha_vencimiento
from articulo a
inner join categoria c on a.idcategoria = c.idcategoria
inner join presentacion p
on a.idpresentacion = p.idpresentacion
inner join detalle_ingreso d on a.idarticulo = d.idarticulo
inner join ingreso i on d.idingreso = i.idingreso
where a.nombre like @txtBuscar + '%'
and d.stock_actual > 0 and i.estado<> 'ANULADO' 
go

--

create proc spBuscarArticuloVentaCodigo
@txtBuscar varchar(50)
as
select d.iddetalle_ingreso, a.codigo,a.nombre,c.nombre as Categoria,p.nombre as Presentacion,
d.stock_actual,d.precio_compra,d.precio_venta,d.fecha_vencimiento
from articulo a
inner join categoria c on a.idcategoria = c.idcategoria
inner join presentacion p
on a.idpresentacion = p.idpresentacion
inner join detalle_ingreso d on a.idarticulo = d.idarticulo
inner join ingreso i on d.idingreso = i.idingreso
where a.codigo = @txtBuscar 
and d.stock_actual > 0 and i.estado<> 'ANULADO' 
go
