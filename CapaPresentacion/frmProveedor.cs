using System;
using System.Windows.Forms;
//

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
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.HabilitarTexto(false);


        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            if (DocumentocomboBox1.Text.Equals("Razon Social"))
            {
                this.BuscarProveedorRazonSocial();
            }
            else
            {
                this.BuscarProveedorNumeroDocumento();   
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string respuesta = string.Empty;
                    string codigo = string.Empty;

                    foreach (DataGridViewRow row in dataListadoGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = NProveedor.Eliminar(Convert.ToInt32(codigo));
                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó Corectamente el registro.....");
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListadoGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoGridView1.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkElliminar = (DataGridViewCheckBoxCell)dataListadoGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                chkElliminar.Value = !Convert.ToBoolean(chkElliminar.Value);
            }
        }

        private void EliminarcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EliminarcheckBox.Checked)
            {
                this.dataListadoGridView1.Columns[0].Visible = true;
            }
            else
            {
                this.dataListadoGridView1.Columns[0].Visible = false;
            }
        }

        private void dataListadoGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.IdProveedortextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["idproveedor"].Value.ToString();
            this.RazonSocialtextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["razon_social"].Value.ToString();
            this.SectorComercialcomboBox.Text = this.dataListadoGridView1.CurrentRow.Cells["sector_comercial"].Value.ToString();
            this.TipoDocumentocomboBox.SelectedValue = this.dataListadoGridView1.CurrentRow.Cells["tipo_documento"].Value.ToString();
            this.NumeroDocumentotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["num_documento"].Value.ToString();
            this.DirecciontextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            this.TelefonotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            this.EmailtextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["email"].Value.ToString();
            this.UrltextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["url"].Value.ToString();

            this.tabControl1.SelectedIndex = 1;
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.HabilitarTexto(true);
            this.RazonSocialtextBox.Focus();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;
                //valido los campos:
                if (this.RazonSocialtextBox.Text == string.Empty || this.NumeroDocumentotextBox.Text == string.Empty 
                   || this.DirecciontextBox.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIconoerrorProvider.SetError(this.RazonSocialtextBox, "Ingrese un Valoe.....");
                    ErrorIconoerrorProvider.SetError(this.NumeroDocumentotextBox, "Ingrese un Valoe.....");
                    ErrorIconoerrorProvider.SetError(this.DirecciontextBox, "Ingrese un Valoe.....");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = NProveedor.Insertat(
                                                        this.RazonSocialtextBox.Text.Trim().ToUpper(), 
                                                        this.SectorComercialcomboBox.Text,
                                                        this.TipoDocumentocomboBox.Text,
                                                        this.NumeroDocumentotextBox.Text,
                                                        this.DirecciontextBox.Text,
                                                        this.TelefonotextBox.Text,
                                                        this.EmailtextBox.Text,
                                                        this.UrltextBox.Text
                                                        );

                    }
                    else
                    {
                        respuesta = NProveedor.Editar(
                                                        Convert.ToInt32(IdProveedortextBox.Text),
                                                        this.RazonSocialtextBox.Text.Trim().ToUpper(),
                                                        this.SectorComercialcomboBox.Text,
                                                        this.TipoDocumentocomboBox.Text,
                                                        this.NumeroDocumentotextBox.Text,
                                                        this.DirecciontextBox.Text,
                                                        this.TelefonotextBox.Text,
                                                        this.EmailtextBox.Text,
                                                        this.UrltextBox.Text
                                                      );
                    }

                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se Insertó de forma correcta el Registro.....");
                        }
                        else
                        {
                            this.MensajeOK("Se Actualizó de forma correcta el Registro.....");
                        }
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            //valido la caja de texto:
            if (!this.IdProveedortextBox.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.HabilitarTexto(true);
            }
            else
            {
                this.MensajeError("Debe Seleccionar primero el registro a Modificar");
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.HabilitarTexto(false);
        }
    }
}
