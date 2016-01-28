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
   public class DTrabajador
    {
        //variables:
        private int idTrabajador;
        private string nombre;
        private string apellidos;
        private string sexo;
        private DateTime fechaNacimeinto;
        private string numeroDocumento;
        private string direccion;
        private string telefono;
        private string email;
        private string acceso;
        private string usuario;
        private string password;
        private string txtBuscar;

        //constructores:

        public DTrabajador()
        { }

        public DTrabajador(int idTrabajador, string nombre, string apellidos, string sexo, DateTime fechaNacimeinto, string numeroDocumento, string direccion, string telefono, string email, string acceso, string usuario, string password, string txtBuscar)
        {
            this.IdTrabajador = idTrabajador;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.FechaNacimeinto = fechaNacimeinto;
            this.NumeroDocumento = numeroDocumento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Acceso = acceso;
            this.Usuario = usuario;
            this.Password = password;
            this.TxtBuscar = txtBuscar;
        }


        //propiedades:

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

        public DateTime FechaNacimeinto
        {
            get
            {
                return fechaNacimeinto;
            }

            set
            {
                fechaNacimeinto = value;
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

        public string Acceso
        {
            get
            {
                return acceso;
            }

            set
            {
                acceso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
        public string Insertar(DTrabajador trabajador)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando:
                SqlCommand cmd = new SqlCommand("spInsertarTrabajador", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //Parametros:
                SqlParameter pIdTrabajador = new SqlParameter("@IdTrabajador", trabajador.IdTrabajador);
                cmd.Parameters.Add(pIdTrabajador);

                SqlParameter pNombre = new SqlParameter("@Nombre", trabajador.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pApellido = new SqlParameter("@Apellido", trabajador.Apellidos);
                cmd.Parameters.Add(pApellido);

                SqlParameter pSexo = new SqlParameter("@Sexo",trabajador.Sexo);
                cmd.Parameters.Add(pSexo);

                SqlParameter pFechaNacimiento = new SqlParameter("@FechaNacimiento",trabajador.FechaNacimeinto);
                cmd.Parameters.Add(pFechaNacimiento);

                //SqlParameter pTipoDocumento = new SqlParameter("@TipoDocumento", cliente.TipoDocumento);
                //cmd.Parameters.Add(pTipoDocumento);

                SqlParameter pNumeroDocumento = new SqlParameter("@NumeroDocumento",trabajador.NumeroDocumento);
                cmd.Parameters.Add(pNumeroDocumento);

                SqlParameter pDireccion = new SqlParameter("@Direccion", trabajador.Direccion);
                cmd.Parameters.Add(pDireccion);

                SqlParameter pTelefono = new SqlParameter("@Telefono", trabajador.Telefono);
                cmd.Parameters.Add(pTelefono);

                SqlParameter pEmail = new SqlParameter("@Email", trabajador.Email);
                cmd.Parameters.Add(pEmail);

                SqlParameter pAcceso = new SqlParameter("@Acceso", trabajador.Acceso);
                cmd.Parameters.Add(pAcceso);

                SqlParameter pUsuario = new SqlParameter("@Usuario", trabajador.Usuario);
                cmd.Parameters.Add(pAcceso);

                SqlParameter pPassword = new SqlParameter("@Password", trabajador.password);
                cmd.Parameters.Add(pPassword);

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
        public string Editar(DTrabajador trabajador)
        {
            string respuesta = "";
            SqlConnection SQlCon = new SqlConnection();
            try
            {
                SQlCon.ConnectionString = Conexion.Cn;
                SQlCon.Open();
                //Establecer comando:
                SqlCommand cmd = new SqlCommand("spEditarTrabajador", SQlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                //Parametros:
                SqlParameter pIdTrabajador = new SqlParameter("@IdTrabajador", trabajador.IdTrabajador);
                cmd.Parameters.Add(pIdTrabajador);

                SqlParameter pNombre = new SqlParameter("@Nombre", trabajador.Nombre);
                cmd.Parameters.Add(pNombre);

                SqlParameter pApellido = new SqlParameter("@Apellido", trabajador.Apellidos);
                cmd.Parameters.Add(pApellido);

                SqlParameter pSexo = new SqlParameter("@Sexo", trabajador.Sexo);
                cmd.Parameters.Add(pSexo);

                SqlParameter pFechaNacimiento = new SqlParameter("@FechaNacimiento", trabajador.FechaNacimeinto);
                cmd.Parameters.Add(pFechaNacimiento);

                //SqlParameter pTipoDocumento = new SqlParameter("@TipoDocumento", cliente.TipoDocumento);
                //cmd.Parameters.Add(pTipoDocumento);

                SqlParameter pNumeroDocumento = new SqlParameter("@NumeroDocumento", trabajador.NumeroDocumento);
                cmd.Parameters.Add(pNumeroDocumento);

                SqlParameter pDireccion = new SqlParameter("@Direccion", trabajador.Direccion);
                cmd.Parameters.Add(pDireccion);

                SqlParameter pTelefono = new SqlParameter("@Telefono", trabajador.Telefono);
                cmd.Parameters.Add(pTelefono);

                SqlParameter pEmail = new SqlParameter("@Email", trabajador.Email);
                cmd.Parameters.Add(pEmail);

                SqlParameter pAcceso = new SqlParameter("@Acceso", trabajador.Acceso);
                cmd.Parameters.Add(pAcceso);

                SqlParameter pUsuario = new SqlParameter("@Usuario", trabajador.Usuario);
                cmd.Parameters.Add(pAcceso);

                SqlParameter pPassword = new SqlParameter("@Password", trabajador.password);
                cmd.Parameters.Add(pPassword);

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

        public string Eliminar(DTrabajador trabajador)
        {
            string respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Comando:
                SqlCommand cmd = new SqlCommand("spEliminarTrabajador", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter pIdTrabajador = new SqlParameter("@IdTrabajador", trabajador.IdTrabajador);
                cmd.Parameters.Add(pIdTrabajador);

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

        //Meétodo mostrar todos los valores del Trabajador:
        public DataTable MostrarTrabajador()
        {
            DataTable dataTableResultado = new DataTable("trabajador");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando;
                SqlCommand cmd = new SqlCommand("spMostrarTrabajador", sqlCon);
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

        //Método buscar spBuscarTrabajadorApellidos de los trabajadores:
        public DataTable BuscarClienteApellidos(DTrabajador trabajador)
        {
            DataTable dataTableResultado = new DataTable("trabajador");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarTrabajadorApellidos", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", trabajador.TxtBuscar);
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

        //Método buscar  spBuscarTrabajadorNumeroDocumento del trabajador:
        public DataTable spBuscarTrabajadorNumeroDocumento(DTrabajador trabajador)
        {
            DataTable dataTableResultado = new DataTable("trabajador");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                //comando:
                SqlCommand cmd = new SqlCommand("spBuscarTrabajadorNumeroDocumento", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros:
                SqlParameter ptxtBuscar = new SqlParameter("@txtBuscar", trabajador.TxtBuscar);
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

