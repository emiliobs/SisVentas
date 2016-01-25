using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //Método Insertar que llama al método insertar de la clase DPresentacion de la CapaDatos:
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion presentacion = new DPresentacion();
            presentacion.Nombre = nombre;
            presentacion.Descripcion = descripcion;
            return presentacion.Insertar(presentacion);
        }

        //Método Editar que llama al método Editar de la clase DPresentacion de la capaDatos:
        public static string Editar(int idPresentacion, string nombre, string descripcion)
        {
            DPresentacion presentacion = new DPresentacion();
            presentacion.IdPresentacion = idPresentacion;
            presentacion.Nombre = nombre;
            presentacion.Descripcion = descripcion;
            return presentacion.Editar(presentacion);
        }

        //Método Eliminar que llama al método Eliminar de la clase DPresentacion de la CapaDatos:
        public static string Eliminar(int idPresentacion)
        {
            DPresentacion presentacion = new DPresentacion();
            presentacion.IdPresentacion = idPresentacion;
            return presentacion.Eliminar(presentacion);
        }

        //Método Mostrar que llama al método mostrar de la clase DPresentacion  de la clase CapaDatos:
        public static DataTable MostrarPresentacion()
        {
            return new DPresentacion().Mostrar();
        }

        //Método BUscarNombre que llama al método BuscarNombre  de la capa DPresentacion de la CapaDATOS:
        public static DataTable BuscarNombrePresentacion(string txtBuscarNombre)
        {
            DPresentacion presentacion = new DPresentacion();
            presentacion.Txtbuscar = txtBuscarNombre;
            return presentacion.BuscarNombre(presentacion);
        }
    }
}
