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
    public partial class frmTrabajador : Form
    {
        private bool IsNuevo;
        private bool IsEditar;

        public frmTrabajador()
        {
            InitializeComponent();
            this.TtMensajetoolTip. SetToolTip(this.NombretextBox,"Ingrese Nombre del Trabajador.");
            this.TtMensajetoolTip.SetToolTip(this.UsuariotextBox,"Ingrese usuario del Trabajador.");
            this.TtMensajetoolTip.SetToolTip(this.ApellidostextBox, "Ingrese Apellidos del Trabajador.");
            this.TtMensajetoolTip.SetToolTip(this.tabControl, "Ingrese Password del Trabajador.");
            this.TtMensajetoolTip.SetToolTip(this.accesocomboBox, "Ingrese el nivel de Accesodel Trabajador.");
            

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
            this.IdTrabajadortextBox.Text = string.Empty;
            this.NombretextBox.Text = string.Empty;
            this.ApellidostextBox.Text = string.Empty;
            this.NumeroDocumentotextBox.Text = string.Empty;
            this.DirecciontextBox.Text = string.Empty;
            this.TelefonotextBox.Text = string.Empty;
            this.EmailtextBox.Text = string.Empty;
            this.UsuariotextBox.Text = string.Empty;
            this.PasswordtextBox.Text = string.Empty;


        }

        //habilitar los controles texto del formulario:
        private void HabilitarTexto(bool valor)
        {
            this.NombretextBox.ReadOnly = !valor;
            this.SexocomboBox.Enabled = valor;
            this.ApellidostextBox.ReadOnly = !valor;
            this.fechaNacimientodateTimePicker.Enabled = valor;
            this.TelefonotextBox.ReadOnly = !valor;
            this.NumeroDocumentotextBox.ReadOnly = !valor;
            this.EmailtextBox.ReadOnly = !valor;
            this.IdTrabajadortextBox.ReadOnly = !valor;
            this.accesocomboBox.Enabled = valor;
            this.PasswordtextBox.ReadOnly = !valor;
            this.UsuariotextBox.ReadOnly = !valor;
            this.DirecciontextBox.ReadOnly = !valor;
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

        //Método  Mostrar los registros table Trabajador:
        private void Mostrar()
        {
            this.dataListadoGridView1.DataSource = NTrabajador.MostrarTrabajador();
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarClienteApellido
        private void BuscaBuscarTrabajadorApellidos()
        {
            this.dataListadoGridView1.DataSource = NTrabajador.BuscarTrabajadorApellidos(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método spBuscarTrabajadorNumeroDocumento:
        private void spBuscarTrabajadorNumeroDocumento()
        {
            this.dataListadoGridView1.DataSource = NTrabajador.spBuscarTrabajadorNumeroDocumento(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
            this.HabilitarTexto(false);
            this.Botones();           

        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            if (DocumentocomboBox1.Text.Equals("Documento"))
            {
                this.spBuscarTrabajadorNumeroDocumento();
            }
            else
            {
                this.BuscaBuscarTrabajadorApellidos();
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
                            respuesta = NTrabajador.Eliminar(Convert.ToInt32(codigo));
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

        private void BuscarnombreTexto_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dataListadoGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoGridView1.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkElliminar = (DataGridViewCheckBoxCell)dataListadoGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                chkElliminar.Value = !Convert.ToBoolean(chkElliminar.Value);
            }
        }

        private void dataListadoGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.IdTrabajadortextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["idtrabajador"].Value.ToString();
            this.NombretextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            this.ApellidostextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["apellidos"].Value.ToString();
            this.SexocomboBox.Text = this.dataListadoGridView1.CurrentRow.Cells["sexo"].Value.ToString();
            this.fechaNacimientodateTimePicker.Value = Convert.ToDateTime(this.dataListadoGridView1.CurrentRow.Cells["fecha_nac"].Value);
            this.NumeroDocumentotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["num_documento"].Value.ToString();
            this.DirecciontextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            this.TelefonotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            this.EmailtextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["email"].Value.ToString();
            this.accesocomboBox.Text = this.dataListadoGridView1.CurrentRow.Cells["acceso"].Value.ToString();
            this.UsuariotextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["usuario"].Value.ToString();
            this.PasswordtextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["password"].Value.ToString();


            this.tabControl.SelectedIndex = 1;
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
                   || this.ApellidostextBox.Text == string.Empty || this.DirecciontextBox.Text == string.Empty ||
                   this.UsuariotextBox.Text == string.Empty || this.PasswordtextBox.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIconoerrorProvider.SetError(this.NombretextBox, "Ingrese un Valor.....");
                    ErrorIconoerrorProvider.SetError(this.NumeroDocumentotextBox, "Ingrese un Valor.....");
                    ErrorIconoerrorProvider.SetError(this.DirecciontextBox, "Ingrese un Valor.....");
                    ErrorIconoerrorProvider.SetError(this.ApellidostextBox, "Ingrese un Valor.....");
                    ErrorIconoerrorProvider.SetError(this.UsuariotextBox, "Ingrese un Valor.....");
                    ErrorIconoerrorProvider.SetError(this.PasswordtextBox, "Ingrese un Valor.....");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = NTrabajador.Insertar(
                                                        this.NombretextBox.Text.Trim().ToUpper(),
                                                        this.ApellidostextBox.Text.Trim().ToUpper(),
                                                        this.SexocomboBox.Text,
                                                        this.fechaNacimientodateTimePicker.Value,
                                                        this.NumeroDocumentotextBox.Text,
                                                        this.DirecciontextBox.Text,
                                                        this.TelefonotextBox.Text,
                                                        this.EmailtextBox.Text,
                                                        this.accesocomboBox.Text,
                                                        this.UsuariotextBox.Text,
                                                        this.PasswordtextBox.Text
                                                        );

                    }
                    else
                    {
                        respuesta = NTrabajador.Editar(Convert.ToInt32(IdTrabajadortextBox.Text),
                                                       this.NombretextBox.Text.Trim().ToUpper(),
                                                        this.ApellidostextBox.Text.Trim().ToUpper(),
                                                        this.SexocomboBox.Text,
                                                        this.fechaNacimientodateTimePicker.Value,
                                                        this.NumeroDocumentotextBox.Text,
                                                        this.DirecciontextBox.Text,
                                                        this.TelefonotextBox.Text,
                                                        this.EmailtextBox.Text,
                                                        this.accesocomboBox.Text,
                                                        this.UsuariotextBox.Text,
                                                        this.PasswordtextBox.Text
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

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.HabilitarTexto(false);
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            //valido la caja de texto:
            if (!this.IdTrabajadortextBox.Text.Equals(""))
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

        private void DocumentocomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
