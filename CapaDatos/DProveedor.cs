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
   public class DProveedor
    {
        //Varaibles:
        private int idProveedor;
        private string razonSocial;
        private string sectorComercial;
        private string tipoDocumento;
        private string numeroDocumento;
        private string direccion;
        private string telefono;
        private string email;
        private string url;
        private string textoBuscar;


        //Propiedades:
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

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
            }
        }

        public string SectorComercial
        {
            get
            {
                return sectorComercial;
            }

            set
            {
                sectorComercial = value;
            }
        }

        public string TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return numeroDocumento;
            }

            set
            {
                numeroDocumento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return textoBuscar;
            }

            set
            {
                textoBuscar = value;
            }
        }

        public DProveedor()
        { }

        public DProveedor(int idProveedor, string razonSocial, string sectorComercial, string tipoDocumento, string numeroDocumento, string direccion, string telefono, string email, string url, string textoBuscar)
        {
            this.IdProveedor = idProveedor;
            this.RazonSocial = razonSocial;
            this.SectorComercial = sectorComercial;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textoBuscar;
        }

        //Métodos:
        //Método Insertar Proveedor: es publico para que se pueda comunicar con las demas capas...
        public string Insertar(DProveedor proveedor)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarProvedor", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdProveedor = new SqlParameter("@IdProveedor", proveedor.IdProveedor);
                cmd.Parameters.Add(@IdProveedor);

                SqlParameter pRazonSocial = new SqlParameter("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.Add(pRazonSocial);

                SqlParameter pSectorComercial = new SqlParameter("@SectorComercial", proveedor.SectorComercial);
                cmd.Parameters.Add(pSectorComercial);

                SqlParameter pTipoDocumento = new SqlParameter("@TipoDocumento", proveedor.TipoDocumento);
                cmd.Parameters.Add(pTipoDocumento);

                SqlParameter pNumeroDocumento = new SqlParameter("@NumeroDocumento", proveedor.NumeroDocumento);
                cmd.Parameters.Add(pNumeroDocumento);

                SqlParameter pDireccion = new SqlParameter("@Direccion", proveedor.Direccion);
                cmd.Parameters.Add(pSectorComercial);

                SqlParameter pTelefono = new SqlParameter("@Telefono", proveedor.Telefono);
                cmd.Parameters.Add(pTelefono);

                SqlParameter pEmail = new SqlParameter("@Email", proveedor.Email);
                cmd.Parameters.Add(pEmail);

                SqlParameter pUrl = new SqlParameter("@Url", proveedor.Url);
                cmd.Parameters.Add(pUrl);

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
        public string Editar(DProveedor proveedor)
        {
            string respuesta = "";
            SqlConnection SQlCon = new SqlConnection();
            try
            {
                SQlCon.ConnectionString = Conexion.Cn;
                SQlCon.Open();
                //Establecer comando:
                SqlCommand cmd = new SqlCommand("spEditarProvedor", SQlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                //Parametros:
                SqlParameter pIdProveedor = new SqlParameter("@IdProveedor", proveedor.IdProveedor);
                cmd.Parameters.Add(@IdProveedor);

                SqlParameter pRazonSocial = new SqlParameter("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.Add(pRazonSocial);

                SqlParameter pSectorComercial = new SqlParameter("@SectorComercial", proveedor.SectorComercial);
                cmd.Parameters.Add(pSectorComercial);

                SqlParameter pTipoDocumento = new SqlParameter("@TipoDocumento", proveedor.TipoDocumento);
                cmd.Parameters.Add(pTipoDocumento);

                SqlParameter pNumeroDocumento = new SqlParameter("@NumeroDocumento", proveedor.NumeroDocumento);
                cmd.Parameters.Add(pNumeroDocumento);

                SqlParameter pDireccion = new SqlParameter("@Direccion", proveedor.Direccion);
                cmd.Parameters.Add(pSectorComercial);

                SqlParameter pTelefono = new SqlParameter("@Telefono", proveedor.Telefono);
                cmd.Parameters.Add(pTelefono);

                SqlParameter pEmail = new SqlParameter("@Email", proveedor.Email);
                cmd.Parameters.Add(pEmail);

                SqlParameter pUrl = new SqlParameter("@Url", proveedor.Url);
                cmd.Parameters.Add(pUrl);

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

        public string Eliminar(DProveedor proveedor)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("spEliminarProveedor", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pIdCategoria = new SqlParameter("@IdProveedor", proveedor.IdProveedor);
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

        //Meétodo mostrar todos los valores de proveedor:
        public DataTable MostrarProveedor()
        {
            DataTable dataTableResultado = new DataTable("proveedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spMostrarProveedor", sqlCon);
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

        //Método buscar ProveedorNumeroDocumento de las Proveedores:
        public DataTable BuscarProveedorNumeroDocumento(DProveedor proveedor)
        {
            DataTable dataTableResultado = new DataTable("proveedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarProveedorNumeroDocumento", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", proveedor.TextoBuscar);
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

        //Método buscar  BuscarProveedorRazonSocia de las Proveedores:
        public DataTable BuscarProveedorRazonSocial(DProveedor proveedor)
        {
            DataTable dataTableResultado = new DataTable("proveedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarProveedorRazonSocial", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", proveedor.TextoBuscar);
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
