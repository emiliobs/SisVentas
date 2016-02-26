using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NArticulo
    {
        //Método Insertar que llama al método insertar de la clase DPresentacion de la CapaDatos:
        public static string Insertar(string codigo,string nombre, string descripcion, 
                                      byte[] imagen,int idCategoria, int idPresentacion)
        {
            DArticulo articulo = new DArticulo();
            articulo.Codigo = codigo;
            articulo.Nombre = nombre;
            articulo.Descripcion = descripcion;
            articulo.Imagen = imagen;
            articulo.IdCategoria = idCategoria;
            articulo.IdPresentacion = idPresentacion;
            return articulo.Insertar(articulo);
        }

        //Método Editar que llama al método Editar de la clase DPresentacion de la capaDatos:
        public static string Editar(int idArticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion)
        {
            DArticulo articulo = new DArticulo();
            articulo.IdArticulo = idArticulo;
            articulo.Codigo = codigo;
            articulo.Nombre = nombre;
            articulo.Descripcion = descripcion;
            articulo.Imagen = imagen;
            articulo.IdCategoria = idCategoria;
            articulo.IdPresentacion = idPresentacion;
            return articulo.Editar(articulo);
        }

        //Método Eliminar que llama al método Eliminar de la clase DPresentacion de la CapaDatos:
        public static string Eliminar(int idArticulo)
        {
            DArticulo articulo = new DArticulo();
            articulo.IdArticulo = idArticulo;
            return articulo.Eliminar(articulo);
        }

        //Método Mostrar que llama al método mostrar de la clase DPresentacion  de la clase CapaDatos:
        public static DataTable MostrarArticulo()
        {
            return new DArticulo().Mostrar();
        }

        //Método BUscarNombre que llama al método BuscarNombre  de la capa DPresentacion de la CapaDATOS:
        public static DataTable BuscarNombreArticulo(string txtBuscarNombre)
        {
            DArticulo articulo = new DArticulo();
            articulo.TxtBuscar = txtBuscarNombre;
            return articulo.BuscarNombre(articulo);
        }

        public static DataTable StockArticulos()
        {
            return new DArticulo().StockArticulos();
        }
    }
}
