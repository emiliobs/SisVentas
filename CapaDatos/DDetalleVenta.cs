using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    //Constructores:
    public class DDetalleVenta
    {
        private int idDetalleVenta;
        private int idVenta;
        private  int idDetalleIngreso;
        private int cantidad;
        private decimal precioVenta;
        private decimal descuento;

        public DDetalleVenta(int idDetalleVenta, int idVenta, int idDetalleIngreso, int cantidad, decimal precioVenta, decimal descuento)
        {
            this.IdDetalleVenta = idDetalleVenta;
            this.IdVenta = idVenta;
            this.IdDetalleIngreso = idDetalleIngreso;
            this.Cantidad = cantidad;
            this.PrecioVenta = precioVenta;
            this.Descuento = descuento;
        }


        //Propiedades:
        public
        DDetalleVenta()
        {

        }

        public int IdDetalleVenta
        {
            get
            {
                return idDetalleVenta;
            }

            set
            {
                idDetalleVenta = value;
            }
        }

        public int IdVenta
        {
            get
            {
                return idVenta;
            }

            set
            {
                idVenta = value;
            }
        }

        public int IdDetalleIngreso
        {
            get
            {
                return idDetalleIngreso;
            }

            set
            {
                idDetalleIngreso = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public decimal Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        //Método Insertar:
        public string Insertar(DDetalleVenta DetalleVenta,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spInsertarDetalleVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pariddetalle_venta = new SqlParameter("@iddetalle_venta", DetalleVenta.IdDetalleVenta);
                SqlCmd.Parameters.Add(Pariddetalle_venta);

                SqlParameter Paridventa = new SqlParameter("@idventa", DetalleVenta.IdDetalleVenta);
                SqlCmd.Parameters.Add(Paridventa);

                SqlParameter Pariddetalle_ingreso = new SqlParameter("@iddetalle_ingreso", DetalleVenta.IdDetalleIngreso);
                SqlCmd.Parameters.Add(Pariddetalle_ingreso);


                SqlParameter Parcantidad = new SqlParameter("@cantidad", DetalleVenta.Cantidad);
                SqlCmd.Parameters.Add(Parcantidad);

                SqlParameter Parprecio_venta = new SqlParameter("@precio_venta", DetalleVenta.PrecioVenta);
                SqlCmd.Parameters.Add(Parprecio_venta);


                SqlParameter Pardescuento = new SqlParameter("@descuento", DetalleVenta.Descuento);
                SqlCmd.Parameters.Add(Pardescuento);                

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }
    }
}
