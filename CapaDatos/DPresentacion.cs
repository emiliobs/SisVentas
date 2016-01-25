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
    public class DPresentacion
    {
        private int idPresentacion;
        private string nombre;
        private string descripcion;
        private string txtbuscar;

        public DPresentacion(int idPresentacion, string nombre, string descripcion, string txtbuscar)
        {
            this.idPresentacion = idPresentacion;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.txtbuscar = txtbuscar;
        }

        public DPresentacion()
        {
        }

        public int IdPresentacion
        {
            get
            {
                return idPresentacion;
            }

            set
            {
                idPresentacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Txtbuscar
        {
            get
            {
                return txtbuscar;
            }

            set
            {
                txtbuscar = value;
            }
        }

        //Insertar Presentación:
        public string Insertar(DPresentacion presentacion)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spinsertarPresentacion", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIDPresentacion = new SqlParameter("@IdPresentacion", presentacion.IdPresentacion);
                cmd.Parameters.Add(pIDPresentacion);

                SqlParameter pNombre = new SqlParameter("@Nombre", presentacion.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pDescripcion = new SqlParameter("@Descripcion", presentacion.Descripcion);
                cmd.Parameters.Add(pDescripcion);

                //Ejecutamos nuestro comando:
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingres el Resgistro.....";


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

        //Método editat:
        public string Editar(DPresentacion presentacion)
        {
            string respuesta = "";
            SqlConnection SQlCon = new SqlConnection();
            try
            {
                SQlCon.ConnectionString = Conexion.Cn;
                SQlCon.Open();
                //Establecer comando:
                SqlCommand cmd = new SqlCommand("speditarPresentntacion", SQlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:

                SqlParameter pIDPresentacion = new SqlParameter("@Idpresentacion", presentacion.IdPresentacion);
                cmd.Parameters.Add(pIDPresentacion);
                SqlParameter pNombre = new SqlParameter("@Nombre", presentacion.Nombre);
                cmd.Parameters.Add(pNombre);
                SqlParameter pDescripcion = new SqlParameter("@Descripcion", presentacion.Descripcion);
                cmd.Parameters.Add(pDescripcion);

                //Ejecuto el comando:

                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo el Registro.....";
            }
            catch (Exception ex)
            {

                respuesta = "ERROR: " + ex.Message;
            }
            finally
            {
                if (SQlCon.State == ConnectionState.Open)
                {
                    SQlCon.Close();
                }
            }

            return respuesta;
        }

        //Método Eliminar

        public string Eliminar(DPresentacion presentacion)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("speliminarPresentacion", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pIDPresentacion = new SqlParameter("@Idpresentacion", presentacion.IdPresentacion);
                cmd.Parameters.Add(pIDPresentacion);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO Se Elimino el Registro.....";

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

        //Meétodo mostrar todos los valores de categoría:
        public DataTable Mostrar()
        {
            DataTable dataTableResultado = new DataTable("presentacion");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spmostrarPresentacion", sqlCon);
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

        //Método buscar Nombres de las Categoría:
        public DataTable BuscarNombre(DPresentacion presentacion)
        {
            DataTable dataTableResultado = new DataTable("presentacion");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spbuscarPresentacionNombre", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", presentacion.Txtbuscar);
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
