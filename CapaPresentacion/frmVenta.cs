using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        private bool IsNuevo = false;
        private int IdTrabajador;
        private DataTable dtDetalleVentas;

        private decimal totalPagado = 0;

        private static frmVenta Instancia;

        public static frmVenta GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new frmVenta();

            }

            return Instancia;
        }

        public void setCliente(string idCliente, string Nombre)
        {
            this.txtIdCliente.Text = idCliente;
            this.txtCliente.Text = Nombre;
        }

        public void setArticulo(
                                string iddetalleIngreso, string nombre, 
                                decimal precioCompra,decimal precioVenta, int stockActual, 
                                DateTime fechaVencimiento
                                )
           {
            this.txtIdArticulo.Text = iddetalleIngreso;
            this.txtArticulo.Text = nombre;
            this.txtPrecio_Compra.Text = precioCompra.ToString();
            this.txtPrecio_Venta.Text = precioVenta.ToString();
            this.txtStockActual.Text = stockActual.ToString();
            this.dtFecha_Vencimiento.Value = fechaVencimiento;

           }
        
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia = null;
        }
    }
}
