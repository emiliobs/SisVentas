using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NCategoria
    {
        //Método Insertar que llama al método insertar de la clase DCategoria de la CapaDatos:
        public static string Insertat(string nombre, string descripcion)
        {
            DCategoria categoria = new DCategoria();
            categoria.Nombre = nombre;
            categoria.Descripcion = descripcion;
            return categoria.Insertar(categoria);
        }  

        //Método Editar que llama al método Editar de la clase DCategoría de la capaDatos:
        public static string Editar(int iNCategoria, string nombre, string descripcion)
        {
            DCategoria categoria = new DCategoria();
            categoria.IdCategoria = iNCategoria;
            categoria.Nombre = nombre;
            categoria.Descripcion = descripcion;
            return categoria.Editar(categoria);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoria de la CapaDatos:
        public static string Eliminar(int idCategoria)
        {
            DCategoria categoria = new DCategoria();
            categoria.IdCategoria = idCategoria;
            return categoria.Eliminar(categoria);   
        }

        //Método Mostrar que llama al método mostrar de la clase DCategoría  de la clase CapaDatos:
        public static DataTable MostrarCategoria()
        {
            return new DCategoria().Mostrar();
        }

        //Método BUscarNombre que llama al método BuscarNombre  de la capa DCategoria de la CapaDATOS:
         public static DataTable BuscarNombre(string nombre)
         {
            DCategoria categoria = new DCategoria();
            categoria.TxtBuscar = nombre;
            return categoria.BuscarNombre(categoria);
         }

    }
}
