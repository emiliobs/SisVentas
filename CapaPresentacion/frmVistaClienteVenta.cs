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
    public partial class frmVistaClienteVenta : Form
    {
        public frmVistaClienteVenta()
        {
            InitializeComponent();
        }

        private void frmVistaClienteVenta_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //Ocultar columnas:
        private void OcultarColumnas()
        {
            this.dataListadoGridView1.Columns[0].Visible = false;
            this.dataListadoGridView1.Columns[1].Visible = false;
        }

        //Método  Mostrar los registros table cliente:
        private void Mostrar()
        {
            this.dataListadoGridView1.DataSource = NCliente.MostrarCliente();
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarClienteApellidos:
        private void BuscarClienteApellidos()
        {
            this.dataListadoGridView1.DataSource = NCliente.BuscarClienteApellidos(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarClienteNumeroDocumento:
        private void BuscarClienteNumeroDocumento()
        {
            this.dataListadoGridView1.DataSource = NCliente.BuscarClienteNumeroDocumento(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

       

        private void dataListadoGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoGridView1.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkElliminar = (DataGridViewCheckBoxCell)dataListadoGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                chkElliminar.Value = !Convert.ToBoolean(chkElliminar.Value);
            }
        }

        private void BuscarnombreTexto_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        

        private void buscarBoton_Click_1(object sender, EventArgs e)
        {
            if (DocumentocomboBox1.Text.Equals("Apellidos"))
            {
                this.BuscarClienteApellidos();
            }
            else
            {
                this.BuscarClienteNumeroDocumento();
            }
        }

        private void dataListadoGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataListadoGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmVenta frm = frmVenta.GetInstancia();
            string idCliente, nombre;

            idCliente = this.dataListadoGridView1.CurrentRow.Cells["idcliente"].Value.ToString();
            nombre    = this.dataListadoGridView1.CurrentRow.Cells["Apellidos"].Value.ToString() + " " +
                        this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value.ToString();


            frm.setCliente(idCliente, nombre);
            this.Hide();



        }
    }
}
