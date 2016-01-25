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
   public class DCategoria
    {
        private int idCategoria;
        private string nombre;
        private string descripcion;
        //para buscar los nombres de las categoría:
        private string txtBuscar;

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
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

        public string TxtBuscar
        {
            get
            {
                return txtBuscar;
            }

            set
            {
                txtBuscar = value;
            }
        }

        //contructor vacio:
        public DCategoria()
        { 
        }

        public DCategoria(int idCategoria, string nombre, string descripcion, string txtBuscar)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
            TxtBuscar = txtBuscar;
        }

        //Método Insertar Categoría: es publico para que se pueda comunicar con las demas capas...
         public string Insertar(DCategoria categoria)
         {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarCategoria", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdCategoria = new SqlParameter("@IdCategoria", categoria.IdCategoria);
                cmd.Parameters.Add(pIdCategoria);

                SqlParameter pNombre = new SqlParameter("@Nombre", categoria.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pDescripcion = new SqlParameter("@Descripción", categoria.Descripcion);
                cmd.Parameters.Add(pDescripcion);

               //Ejecutamos nuestro comando:
               respuesta =  cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingres el Resgistro.....";


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
         public string Editar(DCategoria categoria)
         {
            string respuesta = "";
            SqlConnection SQlCon = new SqlConnection();
            try
            {
                SQlCon.ConnectionString = Conexion.Cn;
                SQlCon.Open();
                //Establecer comando:
                SqlCommand cmd = new SqlCommand("spEditarCategoria", SQlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:

                SqlParameter pIdcategoria = new SqlParameter("@IdCategoria", categoria.IdCategoria);
                cmd.Parameters.Add(pIdcategoria);
                SqlParameter pNombre = new SqlParameter("@Nombre", categoria.Nombre);
                cmd.Parameters.Add(pNombre);
                SqlParameter pDescripcion = new SqlParameter("@Descripcion", categoria.Descripcion);
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

        public string Eliminar(DCategoria categoria)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("spEliminarCategoria", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pIdCategoria = new SqlParameter("@IdCategoria", categoria.IdCategoria);
                cmd.Parameters.Add(pIdCategoria);

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
            DataTable dataTableResultado = new DataTable("categoria");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spMostrarCategoria", sqlCon);
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
        public DataTable BuscarNombre(DCategoria categoria)
        {
            DataTable dataTableResultado = new DataTable("categoria");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarCategoria", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", categoria.TxtBuscar);
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
