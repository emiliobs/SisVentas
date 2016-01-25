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
using System.Data;

namespace CapaPresentacion
{
    public partial class frmProveedor : Form
    {

        public bool IsNuevo = false;
        public bool IsEditar = false;
        public frmProveedor()
        {
            InitializeComponent();

            this.TtMensajetoolTip.SetToolTip(this.RazonSocialtextBox,"Ingrrse Razón social del Proveedor.....");
            this.TtMensajetoolTip.SetToolTip(this.NumeroDocumentotextBox, "Ingrrse Número de documento del Proveedor.....");
            this.TtMensajetoolTip.SetToolTip(this.DirecciontextBox, "Ingrrse Dirección del Proveedor.....");
        }

        //Mostrar Mensaje de confirmación:
        public void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Mostrar Mensaje de Error:
        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario;
        private void Limpiar()
        {
            this.RazonSocialtextBox.Text = string.Empty;
            this.NumeroDocumentotextBox.Text = string.Empty;
            this.DirecciontextBox.Text = string.Empty;
            this.TelefonotextBox.Text = string.Empty;
            this.UrltextBox.Text = string.Empty;
            this.EmailtextBox.Text = string.Empty;
            this.IdProveedortextBox.Text = string.Empty;
        }

        //habilitar los controles texto del formulario:
        private void HabilitarTexto(bool valor)
        {
            this.RazonSocialtextBox.ReadOnly = !valor;
            this.SectorComercialcomboBox.Enabled = valor;
            this.TipoDocumentocomboBox.Enabled = valor;
            this.NumeroDocumentotextBox.ReadOnly = !valor;
            this.DirecciontextBox.ReadOnly = !valor;
            this.TelefonotextBox.ReadOnly = !valor;                                                               
            this.UrltextBox.ReadOnly = !valor;
            this.EmailtextBox.ReadOnly = !valor;
            this.IdProveedortextBox.ReadOnly = !valor;
        }

        //Habilitar botones:
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.HabilitarTexto(true);
                this.Nuevobutton.Enabled = false;
                this.Guardarbutton.Enabled = true;
                this.Editarbutton.Enabled = false;
                this.Cancelarbutton.Enabled = true;

            }
            else
            {
                this.HabilitarTexto(false);
                this.Nuevobutton.Enabled = true;
                this.Guardarbutton.Enabled = false;
                this.Editarbutton.Enabled = true;
                this.Cancelarbutton.Enabled = false;
            }
        }

        //Ocultar columnas:
        private void OcultarColumnas()
        {
            this.dataListadoGridView1.Columns[0].Visible = false;
            this.dataListadoGridView1.Columns[1].Visible = false;
        }

        //Método  Mostrar los registros table categoría:
        private void Mostrar()
        {
            this.dataListadoGridView1.DataSource = NProveedor.MostrarProveedor();
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarProveedorRazonSocial:
        private void BuscarProveedorRazonSocial()
        {
            this.dataListadoGridView1.DataSource = NProveedor.BuscarProveedorRazonSocial(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarProveedorNumeroDocumento
        private void BuscarProveedorNumeroDocumento()
        {
            this.dataListadoGridView1.DataSource = NProveedor.BuscarProveedorNumeroDocumento(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
