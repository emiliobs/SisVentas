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
    public partial class frmVistaCategoriaArticulo : Form
    {
        public frmVistaCategoriaArticulo()
        {
            InitializeComponent();
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

        private void frmVistaCategoriaArticulo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BuscarnombreTexto_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void dataListadoGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Llamo la instancia creada en frmCAtegoria:
            frmArticulo form = frmArticulo.GetInstancia();

            string IdCategoria, NombreCategoria;
            IdCategoria = Convert.ToString( this.dataListadoGridView1.CurrentRow.Cells["idcategoria"].Value);
            NombreCategoria =Convert.ToString (this.dataListadoGridView1.CurrentRow.Cells["nombre"].Value);

            //llamo al método GetCategoria del frmCategoria:
            form.setCategoria(IdCategoria, NombreCategoria);

            //Aqui referencio al frmVistaCategoriaArticulo para cerrarlo o ocultarlo....
            this.Hide();
        }

        private void dataListadoGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
