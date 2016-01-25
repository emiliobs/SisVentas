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
    public partial class frmArticulo : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static frmArticulo Instancia;

        public static frmArticulo GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new frmArticulo();
            }

            return Instancia;
        }

        public void setCategoria(string IdCategoria, string nombreCategoria)
        {
            this.IdCategoriatextBox.Text = IdCategoria;
            this.NombreCAtegoriatextBox.Text = nombreCategoria;
        }

        public frmArticulo()
        {
            InitializeComponent();

            //Muestro mensaje de ayuda sobre lo textbox:
            this.TtMensajetoolTip.SetToolTip(this.NombretextBox, "Ingrese el Nombre del Artículo.....");
            this.TtMensajetoolTip.SetToolTip(this.ImagenpictureBox,"Selecciones Imagen del Artículo.....");
            this.TtMensajetoolTip.SetToolTip(this.NombreCAtegoriatextBox,"Seleccione la Categoría del Artículo.....");
            this.TtMensajetoolTip.SetToolTip(this.PresentacioncomboBox,"Seleccione la Presentacón del Artículo.....");

            this.IdCategoriatextBox.Visible = true;
            this.IdCategoriatextBox.ReadOnly = true;
            this.IdArticulotextBox.ReadOnly = true;
            this.NombreCAtegoriatextBox.ReadOnly = true;
            this.LlenarComboBoxPresentacion();
            //this.Mostrar();
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
            this.codigoVentastextBox.Text = string.Empty;
            this.NombretextBox.Text = string.Empty;
            this.DescripciontextBox.Text = string.Empty;
            
            this.IdArticulotextBox.Text = string.Empty;
            this.IdCategoriatextBox.Text = string.Empty;
            this.NombreCAtegoriatextBox.Text = string.Empty;
            this.ImagenpictureBox.Image = global::CapaPresentacion.Properties.Resources.fondoBlanco;
        }

        //habilitar los controles texto del formulario:
        private void HabilitarTexto(bool valor)
        {
            this.IdArticulotextBox.ReadOnly = !valor;
            this.codigoVentastextBox.ReadOnly = !valor;
            this.NombretextBox.ReadOnly = !valor;
            this.DescripciontextBox.ReadOnly = !valor;
           
            this.BuscarCategoriabutton.Enabled = valor;
            this.PresentacioncomboBox.Enabled = valor;
            this.Guardarbutton.Enabled = valor;
            this.limpiarImagenbutton.Enabled = valor;
            
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
            this.dataListadoGridView1.Columns[6].Visible = false;
            this.dataListadoGridView1.Columns[8].Visible = false;

        }

        //Método  Mostrar los registros table categoría:
        private void Mostrar()
        {
            this.dataListadoGridView1.DataSource = NArticulo.MostrarArticulo();
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarNombre:
        private void BuscarNombre()
        {
            this.dataListadoGridView1.DataSource = NArticulo.BuscarNombreArticulo(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Lleno el combobox presentación:
        private void LlenarComboBoxPresentacion()
        {
            this.PresentacioncomboBox.DataSource = NPresentacion.MostrarPresentacion();
            this.PresentacioncomboBox.ValueMember = "idpresentacion";
            this.PresentacioncomboBox.DisplayMember = "nombre";

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.HabilitarTexto(false);
            this.Botones();
           
        }

        private void CargarImagrnbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.ImagenpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.ImagenpictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void limpiarImagenbutton_Click(object sender, EventArgs e)
        {
            this.ImagenpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ImagenpictureBox.Image = global::CapaPresentacion.Properties.Resources.fondoBlanco;
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void BuscarnombreTexto_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
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
                if (
                   this.NombretextBox.Text == string.Empty 
                   || this.IdCategoriatextBox.Text == string.Empty 
                   || this.codigoVentastextBox.Text == string.Empty
                   )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIconoerrorProvider.SetError(NombretextBox, "Ingrese Nombre.....");
                    ErrorIconoerrorProvider.SetError(codigoVentastextBox,"Ingrese un VAlor.....");
                    ErrorIconoerrorProvider.SetError(NombreCAtegoriatextBox,"Ingrese un Valor.....");
                }
                else
                {
                    //Guardar imagen en un BUffer:
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.ImagenpictureBox.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);

                    //Del Buffer a un Arreglo;
                    byte[] imagen = ms.GetBuffer();


                    if (this.IsNuevo)
                    {
                        respuesta = NArticulo.Insertar(
                                                       this.codigoVentastextBox.Text,
                                                       this.NombretextBox.Text.Trim().ToUpper(), 
                                                       this.DescripciontextBox.Text.Trim().ToUpper(),
                                                       imagen,
                                                       Convert.ToInt32( this.IdCategoriatextBox.Text),
                                                       Convert.ToInt32( this.PresentacioncomboBox.SelectedValue)
                                                       );

                    }
                    else
                    {
                        respuesta = NArticulo.Editar(
                                                     Convert.ToInt32(this.IdArticulotextBox.Text),
                                                     this.codigoVentastextBox.Text,
                                                     this.NombretextBox.Text.Trim().ToUpper(),
                                                     this.DescripciontextBox.Text.Trim().ToUpper(),
                                                     imagen,
                                                     Convert.ToInt32(this.IdCategoriatextBox.Text),
                                                     Convert.ToInt32(PresentacioncomboBox.SelectedValue)
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
            if (!this.IdArticulotextBox.Text.Equals(""))
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
            this.IdArticulotextBox.Text = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["idarticulo"].Value);
            this.codigoVentastextBox.Text = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["codigo"].Value);
            this.NombretextBox.Text = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value);
            this.DescripciontextBox.Text = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["descripcion"].Value);

            byte[] imagenBuffer = (byte[]) this.dataListadoGridView1.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            this.ImagenpictureBox.Image = Image.FromStream(ms);
            this.ImagenpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

           this.IdCategoriatextBox.Text = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["idcategoria"].Value);
           this.NombreCAtegoriatextBox.Text = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["Categoria"].Value);
            this.PresentacioncomboBox.SelectedValue = Convert.ToString(this.dataListadoGridView1.CurrentRow.Cells["idpresentacion"].Value);
            
            //Melleva la selelción del registro al TabControl 1:
            this.tabControl1.SelectedIndex = 1;
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
                            respuesta = NArticulo.Eliminar(Convert.ToInt32(codigo));
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

        private void BuscarCategoriabutton_Click(object sender, EventArgs e)
        {
            //Muestro la ventana emergente de frmVistaCategoriaArticulo:
            frmVistaCategoriaArticulo form = new frmVistaCategoriaArticulo();
            form.ShowDialog();
        }
    }
}
