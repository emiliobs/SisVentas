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

        //Metodos:
        public string Insertar(DIngreso Ingreso, List<DDetalleIngreso> DetalleIngreso)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la transacción:
                SqlTransaction SqlTransaccion = SqlCon.BeginTransaction();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarIngreso", SqlCon);
                cmd.Transaction = SqlTransaccion;
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdIngreso = new SqlParameter("@IdIngreso", Ingreso.IdTrabajador);
                cmd.Parameters.Add(pIdIngreso);

                SqlParameter pIdtrabajador = new SqlParameter("@Idtrabajador", Ingreso.IdTrabajador);
                cmd.Parameters.Add(pIdtrabajador);

                SqlParameter pIdProveedor = new SqlParameter("@IdProveedor",Ingreso.IdProveedor);
                cmd.Parameters.Add(pIdProveedor);

                SqlParameter pFecha = new SqlParameter("@Fecha", Ingreso.Fecha);
                cmd.Parameters.Add(pFecha);

                SqlParameter pTipoComprobante = new SqlParameter("@TipoComprobante", Ingreso.TipoComprobante);
                cmd.Parameters.Add(pTipoComprobante);

                SqlParameter pSerie = new SqlParameter("@Serie", Ingreso.Serie);
                cmd.Parameters.Add(pSerie);

                SqlParameter pCorrelativo = new SqlParameter("@Correlativo", Ingreso.Correlativo);
                cmd.Parameters.Add(pCorrelativo);


                SqlParameter pIgv = new SqlParameter("@Igv", Ingreso.Igv);
                cmd.Parameters.Add(pIgv);
                
                SqlParameter pEstado = new SqlParameter("@Estado", Ingreso.Estado);
                cmd.Parameters.Add(pEstado);


                //Ejecutamos nuestro comando:
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingres el Resgistro.....";

                //Si pudo hacer el ingreso - entonces ingreso los detalles a ddetallesiINgreso:
                if (respuesta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado:
                    this.IdIngreso = Convert.ToInt32(cmd.Parameters["@IdIngreso"].Value);

                    foreach (DDetalleIngreso detalleIngresode  in DetalleIngreso)
                    {
                        detalleIngresode.IdIngreso = this.IdIngreso;

                        //Llamar al método intertar de la la clase DDetalleIngreso:
                        respuesta = detalleIngresode.Insertar(detalleIngresode,ref SqlCon, ref SqlTransaccion);

                        if (!respuesta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }

                //Evaluo la variable respuesta si es true o false:
                if (respuesta.Equals("OK"))
                {
                    SqlTransaccion.Commit();
                }
                else
                {
                    SqlTransaccion.Rollback();
                }

            }
            catch (Exception ex)
            {

                respuesta = "ERROR: " + ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;
        }

        //Método Anular:  
        public string Anular(DIngreso Ingreso)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("spAnularIngreso", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pIdIngreso = new SqlParameter("@IdIngreso", Ingreso.IdIngreso);
                cmd.Parameters.Add(pIdIngreso);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO Se Anulo el Registro.....";

            }
            catch (Exception ex)
            {

                respuesta = "ERROR: " + ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;
        }

        //Meétodo mostrar todos los valores de Ingreso:
        public DataTable Mostrar()
        {
            DataTable dataTableResultado = new DataTable("ingreso");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spMostrarIngreso", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataAdapter
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(dataTableResultado);
            }
            catch (Exception)
            {

                dataTableResultado = null;
            }
            sqlCon.Close();
            return dataTableResultado;
        }

        //Método buscarfehas de Ingreso:
        public DataTable BuscarIngresoFecha(string txtBuscar, string txtBuscar2)
        {
            DataTable dataTableResultado = new DataTable("ingreso");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarIngresoFecha", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", txtBuscar);
                cmd.Parameters.Add(ptxtBuscar);

                SqlParameter ptxtBuscar2 = new SqlParameter("@txtBuscar2", txtBuscar2);
                cmd.Parameters.Add(ptxtBuscar2);
                //DataAdaptar:
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(dataTableResultado);

            }
            catch (Exception)
            {

                dataTableResultado = null;
            }

            sqlCon.Close();
            return dataTableResultado;
        }

        //Método spMostrarDetalleIngreso
        public DataTable MostrarDetalleIngreso(string txtBuscar)
        {
            DataTable dataTableResultado = new DataTable("ingreso");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spMostrarDetalleIngreso", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", txtBuscar);
                cmd.Parameters.Add(ptxtBuscar);
                              
                //DataAdaptar:
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(dataTableResultado);

            }
            catch (Exception)
            {

                dataTableResultado = null;
            }

            sqlCon.Close();
            return dataTableResultado;
        }
    }
}
