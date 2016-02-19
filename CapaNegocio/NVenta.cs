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
    public  class NVenta
    {
        public static string Insertar(
                                      int idCliente, 
                                      int idTrabajador, 
                                      DateTime fecha,
                                      string tipoComprobante, 
                                      string serie, 
                                      string correlativo, 
                                      decimal igv,
                                      DataTable dtDetallesVenta
                                      )
        {
            DVenta Obj = new DVenta();
            Obj.IdCliente = idCliente;
            Obj.IdTrabajador = idTrabajador;
            Obj.Fecha = fecha;
            Obj.TipoComprobante = tipoComprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            List<DDetalleVenta> detallesVentas = new List<DDetalleVenta>();
            foreach (DataRow row in dtDetallesVenta.Rows)
            {
                DDetalleVenta detalle = new DDetalleVenta();
                detalle.IdDetalleIngreso = Convert.ToInt32(row["iddetalle_venta"].ToString());
                detalle.IdVenta = Convert.ToInt32(row["idventa"].ToString());
                detalle.IdDetalleIngreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.PrecioVenta = Convert.ToInt32(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                detallesVentas.Add(detalle);
            }
            return Obj.Insertar(Obj, detallesVentas);
        }
        public static string EliminarVentas(int idVenta)
        {
            DVenta Obj = new DVenta();
            Obj.IdVenta = idVenta;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DVenta
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DVenta().MostrarVentas();
        }

        //Método BuscarVentasFecha que llama al método BuscarVentasFecha
        //de la clase DVenta de la CapaDatos

        public static DataTable BuscarFechas(string txtbuscar1, string txtbuscar2)
        {
            DVenta Obj = new DVenta();
            return Obj.BuscarVentasFechas(txtbuscar1, txtbuscar2);
        }

        public static DataTable MostrarDetalleVentas(string txtBuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarDetalleVentas(txtBuscar);
        }

        public static DataTable MostrarArticuloVentaNombre(string txtBuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarArticuloVentaNombre(txtBuscar);
        }

        public static DataTable MostrarArticuloVentaCodigo(string txtBuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarArticuloVentaCodigo(txtBuscar);
        }
    }
}
