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
   public class NCliente
    {
        //Método Insertar que llama al método insertar de la clase Dcliente de la CapaDatos:
        public static string Insertar(
                                      string nombre,
                                      string apellidos,
                                      string sexo,
                                      DateTime fechaNacimiento,
                                      string tipoDocumento,
                                      string numeroDocumento,
                                      string direccion,
                                      string telefono,
                                      string email
                                      )
        {
            DCliente cliente = new DCliente();
            cliente.Nombre = nombre;
            cliente.Apellidos = apellidos;
            cliente.Sexo = sexo;
            cliente.FechaNacimiento = fechaNacimiento;
            cliente.TipoDocumento = tipoDocumento;
            cliente.NumeroDocumento = numeroDocumento;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Email = email;

            return cliente.Insertar(cliente);
        }

        //Método Editar que llama al método Editar de la clase Dcliente de la capaDatos:
        public static string Editar(int idCliente,
                                      string nombre,
                                      string apellidos,
                                      string sexo,
                                      DateTime fechaNacimiento,
                                      string tipoDocumento,
                                      string numeroDocumento,
                                      string direccion,
                                      string telefono,
                                      string email
                                      )
        {
            DCliente cliente = new DCliente();
            cliente.IdCliente = idCliente;
            cliente.Nombre = nombre;
            cliente.Apellidos = apellidos;
            cliente.Sexo = sexo;
            cliente.FechaNacimiento = fechaNacimiento;
            cliente.TipoDocumento = tipoDocumento;
            cliente.NumeroDocumento = numeroDocumento;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Email = email;
            return cliente.Editar(cliente);
            
        }

        //Método Eliminar que llama al método Eliminar de la clase Dcliente de la CapaDatos:
        public static string Eliminar(int IdCliente)
        {
            DCliente cliente = new DCliente();
            cliente.IdCliente = IdCliente;
            return cliente.Eliminar(cliente);
        }

        //Método Mostrar que llama al método mostrar de la clase Dcliente  de la clase CapaDatos:
        public static DataTable MostrarCliente()
        {
            return new DCliente().MostrarCliente();
        }

        //Método BUscarNombre que llama al método BuscarNombre  de la capa Dcliente de la CapaDATOS:
        public static DataTable BuscarClienteApellidos(string txtBuscar)
        {
            DCliente cliente = new DCliente();
            cliente.TxtBuscar = txtBuscar;
            return cliente.BuscarClienteApellidos(cliente);
        }

        public static DataTable BuscarClienteNumeroDocumento(string txtBuscar)
        {
            DCliente cliente = new DCliente();
            cliente.TxtBuscar = txtBuscar;
            return cliente.BuscarClienteNumeroDocumento(cliente);
        }
    }
}
