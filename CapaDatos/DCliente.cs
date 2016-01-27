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
    public class DCliente
    {
        //Variables:
        private int idCliente;
        private string nombre;
        private string apellidos;
        private string sexo;
        private DateTime fechaNacimiento;
        private string tipoDocumento;
        private string numeroDocumento;
        private string direccion;
        private string telefono;
        private string email;
        private string txtBuscar;

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

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
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

        public DCliente()
        {

        }

        public DCliente(int idCliente, string nombre, string apellidos, string sexo, DateTime fechaNacimiento, string tipoDocumento, string numeroDocumento, string direccion, string telefono, string email, string txtBuscar)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.TxtBuscar = txtBuscar;
        }

        //Métodos:
        public string Insertar(DCliente cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarCliente", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdCliente = new SqlParameter("@IdCliente", cliente.IdCliente);
                cmd.Parameters.Add(pIdCliente);

                SqlParameter pNombre = new SqlParameter("@Nombre", cliente.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pApellido = new SqlParameter("@Apellido", cliente.Apellidos);
                cmd.Parameters.Add(pApellido);

                SqlParameter pSexo = new SqlParameter("@Sexo", cliente.Sexo);
                cmd.Parameters.Add(pSexo);

                SqlParameter pFechaNacimiento = new SqlParameter("@FechaNacimiento", cliente.FechaNacimiento);
                cmd.Parameters.Add(pFechaNacimiento);

                SqlParameter pTipoDocumento = new SqlParameter("@TipoDocumento", cliente.TipoDocumento);
                cmd.Parameters.Add(pTipoDocumento);

                SqlParameter pNumeroDocumento = new SqlParameter("@NumeroDocumento", cliente.NumeroDocumento);
                cmd.Parameters.Add(pNumeroDocumento);

                SqlParameter pDireccion = new SqlParameter("@Direccion", cliente.Direccion);
                cmd.Parameters.Add(pDireccion);
               
                SqlParameter pTelefono = new SqlParameter("@Telefono", cliente.Telefono);
                cmd.Parameters.Add(pTelefono);

                SqlParameter pEmail = new SqlParameter("@Email", cliente.Email);
                cmd.Parameters.Add(pEmail);

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
        public string Editar(DCliente cliente)
        {
            string respuesta = "";
            SqlConnection SQlCon = new SqlConnection();
            try
            {
                SQlCon.ConnectionString = Conexion.Cn;
                SQlCon.Open();
                //Establecer comando:
                SqlCommand cmd = new SqlCommand("spEditarCliente", SQlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                //Parametros:
                SqlParameter pIdCliente = new SqlParameter("@IdCliente", cliente.IdCliente);
                cmd.Parameters.Add(pIdCliente);

                SqlParameter pNombre = new SqlParameter("@Nombre", cliente.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pApellido = new SqlParameter("@Apellido", cliente.Apellidos);
                cmd.Parameters.Add(pApellido);

                SqlParameter pSexo = new SqlParameter("@Sexo", cliente.Sexo);
                cmd.Parameters.Add(pSexo);

                SqlParameter pFechaNacimiento = new SqlParameter("@FechaNacimiento", cliente.FechaNacimiento);
                cmd.Parameters.Add(pFechaNacimiento);

                SqlParameter pTipoDocumento = new SqlParameter("@TipoDocumento", cliente.TipoDocumento);
                cmd.Parameters.Add(pTipoDocumento);

                SqlParameter pNumeroDocumento = new SqlParameter("@NumeroDocumento", cliente.NumeroDocumento);
                cmd.Parameters.Add(pNumeroDocumento);

                SqlParameter pDireccion = new SqlParameter("@Direccion", cliente.Direccion);
                cmd.Parameters.Add(pDireccion);

                SqlParameter pTelefono = new SqlParameter("@Telefono", cliente.Telefono);
                cmd.Parameters.Add(pTelefono);

                SqlParameter pEmail = new SqlParameter("@Email", cliente.Email);
                cmd.Parameters.Add(pEmail);

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

        public string Eliminar(DCliente cliente)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("spEliminarCliente", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pIdCliente = new SqlParameter("@IdCliente", cliente.IdCliente);
                cmd.Parameters.Add(pIdCliente);

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

        //Meétodo mostrar todos los valores de Cliente:
        public DataTable MostrarCliente()
        {
            DataTable dataTableResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spMostrarCliente", sqlCon);
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

        //Método buscar PspBuscarClienteApellidos de los cliente:
        public DataTable BuscarClienteApellidos(DCliente cliente)
        {
            DataTable dataTableResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarClienteApellidos", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", cliente.TxtBuscar);
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

        //Método buscar  spBuscarClienteNumeroDocumento del cliente:
        public DataTable BuscarClienteNumeroDocumento(DCliente cliente)
        {
            DataTable dataTableResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarClienteNumeroDocumento", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", cliente.TxtBuscar);
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