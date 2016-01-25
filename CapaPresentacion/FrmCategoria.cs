using System;
using System.Windows.Forms;
//
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategoria : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmCategoria()
        {
            InitializeComponent();
             //Muestro mensaje de ayuda sobre lo textbox:
            this.TtMensajetoolTip.SetToolTip(this.NombretextBox,"Ingrese el Nombre de la Categoría.....");
        }

        //Mostrar Mensaje de confirmación:
        public void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }  
        //Mostrar Mensaje de Error:
        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema de Venta",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario;
        private void Limpiar()
        {
            NombretextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            IdCategoriatextBox.Text = string.Empty;
        }

        //habilitar los controles texto del formulario:
        private void HabilitarTexto(bool valor)
        {
            this.IdCategoriatextBox.ReadOnly = !valor;
            this.NombretextBox.ReadOnly = !valor;
            this.DescripciontextBox.ReadOnly = !valor;
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
            this.dataListadoGridView1.DataSource = NCategoria.MostrarCategoria();
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
        }

        //Método BuscarNombre:
         private void BuscarNombre()
         {
            this.dataListadoGridView1.DataSource = NCategoria.BuscarNombre(this.BuscarnombreTexto.Text);
            this.OcultarColumnas();
            TotalLabel.Text = "Total de Registros: " + Convert.ToString(dataListadoGridView1.Rows.Count);
         }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            //ubicación del formulario:
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.HabilitarTexto(false);
            this.Botones();
            //this.OcultarColumnas();
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
                if (this.NombretextBox.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIconoerrorProvider.SetError(NombretextBox,"Ingese Nombre.....");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = NCategoria.Insertat(this.NombretextBox.Text.Trim().ToUpper(), this.DescripciontextBox.Text.Trim().ToUpper());

                    }
                    else
                    {
                        respuesta = NCategoria.Editar(Convert.ToInt32(IdCategoriatextBox.Text),
                                                      NombretextBox.Text.Trim().ToUpper(),
                                                      DescripciontextBox.Text.Trim().ToUpper()); 
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

        private void dataListadoGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.IdCategoriatextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["idcategoria"].Value.ToString();
            this.NombretextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            this.DescripciontextBox.Text = this.dataListadoGridView1.CurrentRow.Cells["descripcion"].Value.ToString();

            //Melleva la selelción del registro al TabControl 1:
            this.tabControl1.SelectedIndex = 1;
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            //valido la caja de texto:
            if (!this.IdCategoriatextBox.Text.Equals(""))
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

        private void dataListadoGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoGridView1.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkElliminar = (DataGridViewCheckBoxCell)dataListadoGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                chkElliminar.Value = !Convert.ToBoolean(chkElliminar.Value);
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea Eliminar los Registros","Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string respuesta = string.Empty;
                    string codigo = string.Empty;

                    foreach(DataGridViewRow row in dataListadoGridView1.Rows)
                    {
                        if(Convert.ToBoolean (row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = NCategoria.Eliminar(Convert.ToInt32(codigo));
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
    }
}
