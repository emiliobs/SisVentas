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
    public partial class frmCliente : Form
    {
        private Boolean IsNuevo = false;
        private Boolean IsEditar = false;
        public frmCliente()
        {
            InitializeComponent();

            this.TtMensajetoolTip.SetToolTip(this.NombretextBox,"Ingrese el Nombre del Cliente.");
            this.TtMensajetoolTip.SetToolTip(this.ApellidostextBox,"Ingrese los Apellidos del Cliente.");
            this.TtMensajetoolTip.SetToolTip(this.DirecciontextBox,"Ingrese la Direcciín del Cliente.");
            this.TtMensajetoolTip.SetToolTip(this.NumeroDocumentotextBox,"Ingrese un Número de Documento del cliente.");
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
            this.IdClintetextBox.Text = string.Empty;
            this.NombretextBox.Text = string.Empty;
            this.ApellidostextBox.Text = string.Empty;               
            this.TelefonotextBox.Text = string.Empty;
            this.NumeroDocumentotextBox.Text = string.Empty;
            this.DirecciontextBox.Text = string.Empty;
            this.TelefonotextBox.Text = string.Empty;
            this.EmailtextBox.Text = string.Empty;
            
        }

        //habilitar los controles texto del formulario:
        private void HabilitarTexto(bool valor)
        {
            this.NombretextBox.ReadOnly = !valor;
            this.SexocomboBox.Enabled = valor;
            this.TipoDocumentocomboBox.Enabled = valor;
            this.ApellidostextBox.ReadOnly = !valor;
            this.fechaNacimientodateTimePicker.Enabled = valor;
            this.TelefonotextBox.ReadOnly = !valor;
            this.NumeroDocumentotextBox.ReadOnly = !valor;
            this.EmailtextBox.ReadOnly = !valor;
            this.IdClintetextBox.ReadOnly = !valor;
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
        private void BuscarProveedorNumeroDocumento()
        {
            this.dataListadoGridView1.DataSource = NCliente.BuscarClienteNumeroDocumento(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load_1(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.HabilitarTexto(false);
            this.Botones();
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

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            if (DocumentocomboBox1.Text.Equals("Apellidos"))
            {
                this.BuscarClienteApellidos();
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
                            respuesta = NCliente.Eliminar(Convert.ToInt32(codigo));
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

            this.IdClintetextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["idcliente"].Value.ToString();
            this.NombretextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            this.ApellidostextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["apellidos"].Value.ToString();
            this.SexocomboBox.Text = this.dataListadoGridView1.CurrentRow.Cells["sexo"].Value.ToString();
            this.fechaNacimientodateTimePicker.Value = Convert.ToDateTime(this.dataListadoGridView1.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.TipoDocumentocomboBox.SelectedValue = this.dataListadoGridView1.CurrentRow.Cells["tipo_documento"].Value.ToString();
            this.NumeroDocumentotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["num_documento"].Value.ToString();
            this.DirecciontextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            this.TelefonotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            this.EmailtextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["email"].Value.ToString();
            

            this.tabControl1.SelectedIndex = 1;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.HabilitarTexto(true);
            this.NombretextBox.Focus();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;
                //valido los campos:
                if (this.NombretextBox.Text == string.Empty || this.NumeroDocumentotextBox.Text == string.Empty
                   || this.ApellidostextBox.Text == string.Empty || this.DirecciontextBox.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIconoerrorProvider.SetError(this.NombretextBox, "Ingrese un Valoe.....");
                    ErrorIconoerrorProvider.SetError(this.NumeroDocumentotextBox, "Ingrese un Valoe.....");
                    ErrorIconoerrorProvider.SetError(this.DirecciontextBox, "Ingrese un Valoe.....");
                    ErrorIconoerrorProvider.SetError(this.ApellidostextBox, "Ingrese un Valoe.....");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = NCliente.Insertar(
                                                        this.NombretextBox.Text.Trim().ToUpper(),
                                                         this.ApellidostextBox.Text.Trim().ToUpper(),
                                                        this.SexocomboBox.Text,
                                                        this.fechaNacimientodateTimePicker.Value,
                                                        this.TipoDocumentocomboBox.Text,
                                                        this.NumeroDocumentotextBox.Text,
                                                        this.DirecciontextBox.Text,
                                                        this.TelefonotextBox.Text,
                                                        this.EmailtextBox.Text
                                                        
                                                        );

                    }
                    else
                    {
                        respuesta = NCliente.Editar(    Convert.ToInt32(IdClintetextBox.Text),
                                                    this.NombretextBox.Text.Trim().ToUpper(),
                                                        this.ApellidostextBox.Text.Trim().ToUpper(),
                                                    this.SexocomboBox.Text,
                                                    this.fechaNacimientodateTimePicker.Value,
                                                    this.TipoDocumentocomboBox.Text,
                                                    this.NumeroDocumentotextBox.Text,
                                                    this.DirecciontextBox.Text,
                                                    this.TelefonotextBox.Text,
                                                    this.EmailtextBox.Text
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
            if (!this.IdClintetextBox.Text.Equals(""))
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
