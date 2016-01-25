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

        //hola emilio don chimbo....



    }
}
