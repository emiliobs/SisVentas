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
    public partial class frmVistaArticuloVenta : Form
    {
        public frmVistaArticuloVenta()
        {
            InitializeComponent();
        }

        private void frmVistaArticuloVenta_Load(object sender, EventArgs e)
        {
          
        }

        //Ocultar columnas:
        private void OcultarColumnas()
        {
            this.dataListadoGridView1.Columns[0].Visible = false;
            this.dataListadoGridView1.Columns[1].Visible = false;
        }

       
        //Método BuscarNombre:
        private void MostrarArticuloVentaNombre()
        {
            this.dataListadoGridView1.DataSource = NVenta.MostrarArticuloVentaNombre(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        private void MostrarArticuloVentaCodigo()
        {
            this.dataListadoGridView1.DataSource = NVenta.MostrarArticuloVentaCodigo(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            if (cboBuscar.Text.Equals("Codigo"))
            {
                this.MostrarArticuloVentaCodigo();
            }
            else if(cboBuscar.Text.Equals("Nombre"))
            {
                this.MostrarArticuloVentaNombre(); 
            }
        }

        private void dataListadoGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmVenta frm = frmVenta.GetInstancia();

            int stockActual;
            string idDetalleIngreso, nombre;
            decimal precioCompra, precioVenta;
            DateTime fechanVencimiento;

            idDetalleIngreso = this.dataListadoGridView1.CurrentRow.Cells["iddetalle_ingreso"].Value.ToString();
            nombre = this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            precioCompra =Convert.ToDecimal(this.dataListadoGridView1.CurrentRow.Cells["precio_compra"].Value);
            precioVenta = Convert.ToDecimal(this.dataListadoGridView1.CurrentRow.Cells["precio_venta"].Value);
            stockActual = Convert.ToInt32(this.dataListadoGridView1.CurrentRow.Cells["stock_actual"].Value);
            fechanVencimiento = Convert.ToDateTime(this.dataListadoGridView1.CurrentRow.Cells["fecha_vencimiento"].Value);

            frm.setArticulo(idDetalleIngreso, nombre,precioCompra,precioVenta,stockActual, fechanVencimiento);

            this.Hide();

        }
    }
}
