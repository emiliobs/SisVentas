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
   public class NTrabajador
  {
        //Métodos:
        //Método Insertar que llama al método insertar de la clase DTrabajador de la CapaDatos:
        public static string Insertar(
                                      string nombre,
                                      string apellidos,
                                      string sexo,
                                      DateTime fechaNacimiento,
                                      string numeroDocumento,
                                      string direccion,
                                      string telefono,
                                      string email  ,
                                      string acceso,
                                      string usuario,
                                      string password
                                      )
        {
            DTrabajador trabajador= new DTrabajador();
            trabajador.Nombre = nombre;
            trabajador.Apellidos = apellidos;
            trabajador.Sexo = sexo;
            trabajador.FechaNacimeinto = fechaNacimiento;
            trabajador.NumeroDocumento = numeroDocumento;
            trabajador.Direccion = direccion;
            trabajador.Telefono = telefono;
            trabajador.Email = email;
            trabajador.Acceso = acceso;
            trabajador.Usuario = usuario;
            trabajador.Password = password;
            return trabajador.Insertar(trabajador);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador de la capaDatos:
        public static string Editar(
                                      int IdTrabador,
                                      string nombre,
                                      string apellidos,
                                      string sexo,
                                      DateTime fechaNacimiento,
                                      string numeroDocumento,
                                      string direccion,
                                      string telefono,
                                      string email,
                                      string acceso,
                                      string usuario,
                                      string password
                                      )
        {
            DTrabajador trabajador = new DTrabajador();
            trabajador.IdTrabajador = IdTrabador;
            trabajador.Nombre = nombre;
            trabajador.Apellidos = apellidos;
            trabajador.Sexo = sexo;
            trabajador.FechaNacimeinto = fechaNacimiento;
            trabajador.NumeroDocumento = numeroDocumento;
            trabajador.Direccion = direccion;
            trabajador.Telefono = telefono;
            trabajador.Email = email;
            trabajador.Acceso = acceso;
            trabajador.Usuario = usuario;
            trabajador.Password = password;
            return trabajador.Editar(trabajador);
        }

        //Método Eliminar que llama al método Eliminar de la clase Dtrabajador de la CapaDatos:
        public static string Eliminar(int IdTrabajador)
        {
            DTrabajador trabajador = new DTrabajador();
            trabajador.IdTrabajador = IdTrabajador;
            return trabajador.Eliminar(trabajador);
        }

        //Método Mostrar que llama al método mostrar de la clase DTrabajador  de la clase CapaDatos:
        public static DataTable MostrarTrabajador()
        {
            return new DTrabajador().MostrarTrabajador();
        }

        //Método BUscarNombre que llama al método BuscarNombre  de la capa DTrabajador de la CapaDATOS:
        public static DataTable spBuscarTrabajadorNumeroDocumento(string txtBuscar)
        {
            DTrabajador trabajador = new DTrabajador();
            trabajador.TxtBuscar = txtBuscar;
            return trabajador.spBuscarTrabajadorNumeroDocumento(trabajador);
        }

        public static DataTable BuscarTrabajadorApellidos(string txtBuscar)
        {
            DTrabajador trabajador = new DTrabajador();
            trabajador.TxtBuscar = txtBuscar;
            return trabajador.BuscarTrabajadorApellidos(trabajador);
        }

        public static DataTable Login(string usuario, string password )
        {
            DTrabajador trabajador = new DTrabajador();
            trabajador.Usuario = usuario;
            trabajador.Password = password;
            return trabajador.Login(trabajador);
        }

    }
}
