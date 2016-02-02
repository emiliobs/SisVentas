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
            this.idDetalleIngreso = idDetalleIngreso;
            this.idIngreso = idIngreso;
            this.idArticulo = idArticulo;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.stockInicial = stockInicial;
            this.stockActual = stockActual;
            this.fechaProduccion = fechaProduccion;
            this.fechaVencimiento = fechaVencimiento;
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
    }
}
