using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using CapaDatos;
using System.Data;

namespace CapaPresentacion
{
   public class NProveedor
    {
        //Método Insertar que llama al método insertar de la clase DProveedor de la CapaDatos:
        public static string Insertat(
                                      string RazonSocial,
                                      string SectorComercial,
                                      string TipoDocumento, 
                                      string NumeroDocumento, 
                                      string Direccion,
                                      string Telefono,
                                      string Email, 
                                      string Url
                                      )
        {
            DProveedor proveedor = new DProveedor();
            proveedor.RazonSocial = RazonSocial;
            proveedor.SectorComercial = SectorComercial;
            proveedor.TipoDocumento = TipoDocumento;
            proveedor.NumeroDocumento = NumeroDocumento;
            proveedor.Direccion = Direccion;
            proveedor.Telefono = Telefono;
            proveedor.Email = Email;
            proveedor.Url = Url;
            return proveedor.Insertar(proveedor);
        }

        //Método Editar que llama al método Editar de la clase DProveedor de la capaDatos:
        public static string Editar(int IdProveedor,string RazonSocial, string SectorComercial,
                                      string TipoDocumento, string NumeroDocumento,
                                      string Direccion,string Telefono, string Email,
                                      string Url)
        {
            DProveedor proveedor = new DProveedor();
            proveedor.IdProveedor = IdProveedor;
            proveedor.RazonSocial = RazonSocial;
            proveedor.SectorComercial = SectorComercial;
            proveedor.TipoDocumento = TipoDocumento;
            proveedor.NumeroDocumento = NumeroDocumento;
            proveedor.Direccion = Direccion;
            proveedor.Telefono = Telefono;
            proveedor.Email = Email;
            proveedor.Url = Url;
            return proveedor.Editar(proveedor);
        }

        //Método Eliminar que llama al método Eliminar de la clase DProveedor de la CapaDatos:
        public static string Eliminar(int idProveedor)
        {
            DProveedor proveedor = new DProveedor();
            proveedor.IdProveedor = idProveedor;
            return proveedor.Eliminar(proveedor);
        }

        //Método Mostrar que llama al método mostrar de la clase DProveedor  de la clase CapaDatos:
        public static DataTable MostrarProveedor()
        {
            return new DProveedor().MostrarProveedor();
        }

        //Método BUscarNombre que llama al método BuscarNombre  de la capa DProveedor de la CapaDATOS:
        public static DataTable BuscarProveedorNumeroDocumento(string txtBuscar)
        {
            DProveedor proveedor = new DProveedor();
            proveedor.TextoBuscar = txtBuscar;
            return proveedor.BuscarProveedorNumeroDocumento(proveedor);
        }

        public static DataTable BuscarProveedorRazonSocial(string txtBuscar)
        {
            DProveedor proveedor = new DProveedor();
            proveedor.TextoBuscar = txtBuscar;
            return proveedor.BuscarProveedorRazonSocial(proveedor);
        }
    }
}
