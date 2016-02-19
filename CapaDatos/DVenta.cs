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
   public class DVenta
    {
        //Variables:
        private int idVenta;
        private int idCliente;
        private int idTrabajador;
        private DateTime fecha;
        private string tipoComprobante;
        private string serie;
        private string correlativo;
        private decimal igv;

        //Constructores:
        public DVenta() { }

        public DVenta(int idVenta, int idCliente, int idTrabajador, DateTime fecha, string tipoComprobante, string serie, string correlativo, decimal igv)
        {
            this.IdVenta = idVenta;
            this.IdCliente = idCliente;
            this.IdTrabajador = idTrabajador;
            this.Fecha = fecha;
            this.TipoComprobante = tipoComprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
        }

        //Propiedades:
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

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
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

        //Métodos:

        public string DisminuirStock(int iddetalleIngreso, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spDisminuirStock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pariddetalle_ingreso = new SqlParameter("@iddetalle_ingreso", iddetalleIngreso);
                SqlCmd.Parameters.Add(Pariddetalle_ingreso);

                SqlParameter Parcantidad = new SqlParameter("@cantidad", cantidad);
                SqlCmd.Parameters.Add(Parcantidad);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Stock.";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Insertar(DVenta venta, List<DDetalleVenta> DetalleVenta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spInsertarVentas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Paridventa = new SqlParameter("@idventa", venta.IdVenta);
                SqlCmd.Parameters.Add(Paridventa);

                SqlParameter Paridcliente = new SqlParameter("@idcliente", venta.IdCliente);
                SqlCmd.Parameters.Add(Paridcliente);

                SqlParameter Paridtrabajador = new SqlParameter("@idtrabajador", venta.IdTrabajador);
                SqlCmd.Parameters.Add(Paridtrabajador);

                SqlParameter Parfecha = new SqlParameter("@fecha",venta.Fecha);
                SqlCmd.Parameters.Add(Parfecha);


                SqlParameter Partipo_comprobante = new SqlParameter("@tipo_comprobante",venta.TipoComprobante);
                SqlCmd.Parameters.Add(Partipo_comprobante);

                SqlParameter Parserie = new SqlParameter("@serie", venta.Serie);
                SqlCmd.Parameters.Add(Parserie);

                SqlParameter Parcorrelativo = new SqlParameter("@correlativo",venta.Correlativo);
                SqlCmd.Parameters.Add(Parcorrelativo);

                SqlParameter Parigv = new SqlParameter("@igv",venta.Igv);
                SqlCmd.Parameters.Add(Parigv);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.IdVenta = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (DDetalleVenta detalleVenta in DetalleVenta)
                    {
                        detalleVenta.IdVenta = this.IdVenta;
                        //Llamar al método insertar de la clase DDetalle_Ingreso
                        rpta = detalleVenta.Insertar(detalleVenta, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizamos el Stock:
                            rpta = DisminuirStock(detalleVenta.IdDetalleIngreso, detalleVenta.Cantidad);

                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        public string Eliminar(DVenta Venta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "soEliminarVentas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Paridventa = new SqlParameter("@idventa", Venta.IdVenta);
                SqlCmd.Parameters.Add(Paridventa);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar
        public DataTable MostrarVentas()
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método spBuscarVentasFechas
        public DataTable BuscarVentasFechas(String txtBuscar1, String txtBuscar2)
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarVentasFechas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PartxtBuscar1 = new SqlParameter("@txtBuscar1",txtBuscar1);
                SqlCmd.Parameters.Add(PartxtBuscar1);

                SqlParameter PartxtBuscar2 = new SqlParameter("@txtBuscar2", txtBuscar2);
                SqlCmd.Parameters.Add(PartxtBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public DataTable MostrarDetalleVentas(String txtBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrarDetalleVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PartxtBuscar = new SqlParameter("@txtBuscar",txtBuscar);
                SqlCmd.Parameters.Add(PartxtBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Mostrar Artíclos por su NOmbre:
        public DataTable MostrarArticuloVentaNombre(String txtBuscar)
        {
            DataTable DtResultado = new DataTable("articulos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarArticuloVentaNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PartxtBuscar = new SqlParameter("@txtBuscar", txtBuscar);
                SqlCmd.Parameters.Add(PartxtBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Mostrar Artíclos por su Código:
        public DataTable MostrarArticuloVentaCodigo(String txtBuscar)
        {
            DataTable DtResultado = new DataTable("articulos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarArticuloVentaNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PartxtBuscar = new SqlParameter("@txtBuscar", txtBuscar);
                SqlCmd.Parameters.Add(PartxtBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
