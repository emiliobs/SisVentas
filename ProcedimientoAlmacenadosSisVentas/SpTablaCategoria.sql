use
dbventas
go
--procedimiento mostrar categoría:
create proc spMostrarCategoria
as
select top 200 * from  categoria
order by idcategoria desc
go

--Procediemiento buscar Nombre Categoría:
create proc spBuscarCategoria
@txtBuscar varchar(50)
as
select * from categoria
where nombre like @txtBuscar + '%'
go

--cprocediiento insertar categoría:
create proc spInsertarCategoria
@IdCategoria int output,
@Nombre varchar(50),
@Descripción varchar(256)
as
insert into categoria(nombre, descripcion) values (@Nombre, @Descripción)
go

--Procedimeinto Editar Categoría:
create proc spEditarCategoria
@IdCategoria int,
@Nombre varchar(50),
@Descripcion varchar(256)
as
update categoria set nombre=@Nombre, descripcion=@Descripcion where idcategoria = @IdCategoria
go

--Procedimiento Eliminar Categoría:
create proc spEliminarCategoria
@IdCategoria int
as
delete from categoria where idcategoria = @IdCategoria
go