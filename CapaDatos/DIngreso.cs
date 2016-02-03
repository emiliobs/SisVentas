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
   public class DIngreso
    {
        //Variables:
        private int idIngreso;
        private int idTrabajador;
        private int idProveedor;
        private DateTime fecha;
        private string tipoComprobante;
        private string serie;
        private string correlativo;
        private decimal igv;
        private string estado;

        public DIngreso() 
        { }

        public DIngreso(int idIngreso, int idTrabajador, int idProveedor, DateTime fecha, string tipoComprobante, string serie, string correlativo, decimal igv, string estado)
        {
            this.IdIngreso = idIngreso;
            this.IdTrabajador = idTrabajador;
            this.IdProveedor = idProveedor;
            this.Fecha = fecha;
            this.TipoComprobante = tipoComprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
            this.Estado = estado;
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

        public int IdTrabajador
        {
            get
            {
                return idTrabajador;
            }

            set
            {
                idTrabajador = value;
            }
        }

        public int IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string TipoComprobante
        {
            get
            {
                return tipoComprobante;
            }

            set
            {
                tipoComprobante = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }

        public string Correlativo
        {
            get
            {
                return correlativo;
            }

            set
            {
                correlativo = value;
            }
        }

        public decimal Igv
        {
            get
            {
                return igv;
            }

            set
            {
                igv = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }


    }
}
