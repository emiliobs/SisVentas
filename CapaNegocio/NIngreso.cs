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
   public class NIngreso
   {
        //Método Insertar que llama al método insertar de la clase DIngreso de la CapaDatos:
        public static string Insertat(int idtrabajador, int idproveedor, DateTime fecha,
                                      string tipoComprobante, string serie, string correlativo,
                                      decimal igv, string estado, DataTable dtDetalle )
        {
            DIngreso ingreso = new DIngreso();
            ingreso.IdTrabajador = idtrabajador;
            ingreso.IdProveedor = idproveedor;
            ingreso.Fecha = fecha;
            ingreso.TipoComprobante = tipoComprobante;
            ingreso.Serie = serie;
            ingreso.Correlativo = correlativo;
            ingreso.Igv = igv;
            ingreso.Estado = estado;

            List<DDetalleIngreso> detalles = new List<DDetalleIngreso>();
            //Recorro todas las filas una a una:
            foreach (DataRow row in dtDetalle.Rows)
            {
                DDetalleIngreso detalle = new DDetalleIngreso();
                detalle.IdArticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.PrecioCompra = Convert.ToInt32(row["precio_compra"].ToString());
                detalle.PrecioVenta = Convert.ToInt32(row["precio_venta"].ToString());
                detalle.StockInicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.StockActual = Convert.ToInt32(row["stock_actual"].ToString());
                detalle.FechaProduccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.FechaVencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());

                detalles.Add(detalle);
            }
            return ingreso.Insertar(ingreso, detalles);
        }


        //Método Nular que llama al método Anular de la clase DIngreso de la CapaDatos:
        public static string Eliminar(int idIngreso)
        {
            DIngreso ingreso = new DIngreso();
            ingreso.IdIngreso = idIngreso;
            return ingreso.Anular(ingreso);
        }

        //Método Mostrar que llama al método mostrar de la clase DIngreso  de la clase CapaDatos:
        public static DataTable MostrarIngreso()
        {
            return new DIngreso().Mostrar();
        }

        //Método BuscarIngresoFecha que llama al método BuscarIngresoFecha  de la capa DIngreso de la CapaDATOS:
        public static DataTable BuscarNombre(string txtBuscar, string txtBuscar2)
        {
            DIngreso ingreso = new DIngreso();

            return ingreso.BuscarIngresoFecha(txtBuscar, txtBuscar2);
        }

        public static DataTable MostrarDetalleIngreso(string txtBuscar)
        {
            DIngreso ingreso = new DIngreso();

            return ingreso.MostrarDetalleIngreso(txtBuscar);
        }

    }
}
