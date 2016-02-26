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
   public class DArticulo
    {
        private int idArticulo;
        private string codigo;
        private string nombre;
        private string descripcion;
        private byte[] imagen;
        private int idCategoria;
        private int idPresentacion;
        private string txtBuscar;

        public DArticulo()
        {
        
         }
    
        public DArticulo(int idArticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion, string txtBuscar)
        {
            this.idArticulo = idArticulo;
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.idCategoria = idCategoria;
            this.idPresentacion = idPresentacion;
            this.txtBuscar = txtBuscar;
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

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
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

        public byte[] Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

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

        //Métodos:
        //Insertar Presentación:
        public string Insertar(DArticulo articulo)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarArticulo", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdArticulo = new SqlParameter("@IdArticulo", articulo.IdArticulo);
                cmd.Parameters.Add(pIdArticulo);

                SqlParameter pCodigo = new SqlParameter("@Codigo", articulo.Codigo);
                cmd.Parameters.Add(pCodigo);

                SqlParameter pNombre = new SqlParameter("@Nombre", articulo.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pDescripcion = new SqlParameter("@Descripcion", articulo.Descripcion);
                cmd.Parameters.Add(pDescripcion);

                SqlParameter pImagen = new SqlParameter("@Imagen", articulo.Imagen);
                cmd.Parameters.Add(pImagen);

                SqlParameter pIdCategoria = new SqlParameter("@IdCategoria", articulo.IdCategoria);
                cmd.Parameters.Add(pIdCategoria);

                SqlParameter pIdPresentacion = new SqlParameter("@IdPresentacion", articulo.IdPresentacion);
                cmd.Parameters.Add(pIdPresentacion);

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
        public string Editar(DArticulo articulo)
        {
            string respuesta = "";
            SqlConnection SQlCon = new SqlConnection();
            try
            {
                SQlCon.ConnectionString = Conexion.Cn;
                SQlCon.Open();
                //Establecer comando:
                SqlCommand cmd = new SqlCommand("spEditarArticulo", SQlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                //Parametros:
                SqlParameter pIdArticulo = new SqlParameter("@IdArticulo", articulo.IdArticulo);
                cmd.Parameters.Add(pIdArticulo);

                SqlParameter pCodigo = new SqlParameter("@Codigo", articulo.Codigo);
                cmd.Parameters.Add(pCodigo);

                SqlParameter pNombre = new SqlParameter("@Nombre", articulo.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pDescripcion = new SqlParameter("@Descripcion", articulo.Descripcion);
                cmd.Parameters.Add(pDescripcion);

                SqlParameter pImagen = new SqlParameter("@Imagen", articulo.Imagen);
                cmd.Parameters.Add(pImagen);

                SqlParameter pIdCategoria = new SqlParameter("@IdCategoria", articulo.IdCategoria);
                cmd.Parameters.Add(pIdCategoria);

                SqlParameter pIdPresentacion = new SqlParameter("@IdPresentacion", articulo.IdPresentacion);
                cmd.Parameters.Add(pIdPresentacion);

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
        public string Eliminar(DArticulo artiuclo)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("spEliminarArticulo", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pidArticulo = new SqlParameter("@IdArticulo", artiuclo.IdArticulo);
                cmd.Parameters.Add(pidArticulo);

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
            DataTable dataTableResultado = new DataTable("articulo");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spMostrarArticulo", sqlCon);
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
        public DataTable BuscarNombre(DArticulo artiuclo)
        {
            DataTable dataTableResultado = new DataTable("articulo");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarArticuloNombre", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", artiuclo.TxtBuscar);
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

        public DataTable StockArticulos()
        {
            DataTable dataTableResultado = new DataTable("articulo");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spStockArticulos", sqlCon);
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
    }
}
