using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class DDetalleIngreso
    {
        //variables:
        private int idDetalleIngreso;
        private int idIngreso;
        private int idArticulo;
        private decimal precioCompra;
        private decimal precioVenta;
        private int stockInicial;
        private int stockActual;
        private DateTime fechaProduccion;
        private DateTime fechaVencimiento;

        //Contructores
        public DDetalleIngreso()
        { }

        public DDetalleIngreso(int idDetalleIngreso, int idIngreso, int idArticulo, decimal precioCompra, decimal precioVenta, int stockInicial, int stockActual, DateTime fechaProduccion, DateTime fechaVencimiento)
        {
            this.IdDetalleIngreso = idDetalleIngreso;
            this.IdIngreso = idIngreso;
            this.IdArticulo = idArticulo;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
            this.StockInicial = stockInicial;
            this.StockActual = stockActual;
            this.FechaProduccion = fechaProduccion;
            this.FechaVencimiento = fechaVencimiento;
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

        public int IdIngreso
        {
            get
            {
                return idIngreso;
            }

            set
            {
                idIngreso = value;
            }
        }

        public int IdArticulo
        {
            get
            {
                return idArticulo;
            }

            set
            {
                idArticulo = value;
            }
        }

        public decimal PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
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

        public int StockInicial
        {
            get
            {
                return stockInicial;
            }

            set
            {
                stockInicial = value;
            }
        }

        public int StockActual
        {
            get
            {
                return stockActual;
            }

            set
            {
                stockActual = value;
            }
        }

        public DateTime FechaProduccion
        {
            get
            {
                return fechaProduccion;
            }

            set
            {
                fechaProduccion = value;
            }
        }

        public DateTime FechaVencimiento
        {
            get
            {
                return fechaVencimiento;
            }

            set
            {
                fechaVencimiento = value;
            }
        }

        //Método Insertar:
        public string Insertar(DDetalleIngreso detalleIngreso, ref SqlConnection SqlCon,
                                ref SqlTransaction SQlTransaccion)
        {
            string respuesta = "";
            //SqlConnection SqlCon = new SqlConnection();
            try
            {
                //SqlCon.ConnectionString = Conexion.Cn;
                //SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarDetalleIngreso", SqlCon);
                cmd.Transaction = SQlTransaccion;
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdDetalleIngreso = new SqlParameter("@IdDetalleIngreso", detalleIngreso.IdDetalleIngreso);
                cmd.Parameters.Add(pIdDetalleIngreso);

                SqlParameter pIdIngreso = new SqlParameter("@IdIngreso", detalleIngreso.IdIngreso);
                cmd.Parameters.Add(pIdIngreso);

                SqlParameter pIdArticulo = new SqlParameter("@IdArticulo", detalleIngreso.IdArticulo);
                cmd.Parameters.Add(pIdArticulo);

                SqlParameter pPrecioCompra = new SqlParameter("@PrecioCompra", detalleIngreso.PrecioCompra);
                cmd.Parameters.Add(pPrecioCompra);

                SqlParameter pPrecioVenta = new SqlParameter("@PrecioVenta", detalleIngreso.PrecioVenta);
                cmd.Parameters.Add(pPrecioVenta);

                SqlParameter pStockInicial = new SqlParameter("@StockInicial", detalleIngreso.StockInicial);
                cmd.Parameters.Add(pStockInicial);

                SqlParameter pStockActual = new SqlParameter("@StockActual", detalleIngreso.StockActual);
                cmd.Parameters.Add(pStockActual);

                SqlParameter pFechaProduccion = new SqlParameter("@FechaProduccion", detalleIngreso.FechaProduccion);
                cmd.Parameters.Add(pFechaProduccion);

                SqlParameter pFechaVencimiento = new SqlParameter("@FechaVencimiento", detalleIngreso.FechaVencimiento);
                cmd.Parameters.Add(pFechaVencimiento);

                
                //Ejecutamos nuestro comando:
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingres el Resgistro.....";


            }
            catch (Exception ex)
            {

                respuesta = "ERROR: " + ex.Message;
            }
           

            return respuesta;
        }
    }
}
