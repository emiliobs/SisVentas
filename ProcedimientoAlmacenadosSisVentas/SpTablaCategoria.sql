use
dbventas
go
--procedimiento mostrar categor�a:
create proc spMostrarCategoria
as
select top 200 * from  categoria
order by idcategoria desc
go

--Procediemiento buscar Nombre Categor�a:
create proc spBuscarCategoria
@txtBuscar varchar(50)
as
select * from categoria
where nombre like @txtBuscar + '%'
go

--cprocediiento insertar categor�a:
create proc spInsertarCategoria
@IdCategoria int output,
@Nombre varchar(50),
@Descripci�n varchar(256)
as
insert into categoria(nombre, descripcion) values (@Nombre, @Descripci�n)
go

--Procedimeinto Editar Categor�a:
create proc spEditarCategoria
@IdCategoria int,
@Nombre varchar(50),
@Descripcion varchar(256)
as
update categoria set nombre=@Nombre, descripcion=@Descripcion where idcategoria = @IdCategoria
go

--Procedimiento Eliminar Categor�a:
create proc spEliminarCategoria
@IdCategoria int
as
delete from categoria where idcategoria = @IdCategoria
go