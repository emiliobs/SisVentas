using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    

    public partial class frmIngreso : Form
    {
        public int Idtrabajador;
        private static frmIngreso Instancia;
        public static frmIngreso GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new frmIngreso();
            }

            return Instancia;
        }

        public void setProveedor(string idProveedor, string nombre)
        {
            this.IdProveedortextBox.Text = idProveedor;
            this.ProveedortextBox.Text = nombre;
        }

        public void setArticulo(string IdArticulo, string nombre)
        {
            this.txtIdArtoculotextBox2.Text = IdArticulo;
            this.ArticulotextBox1.Text = nombre;  
        }

        public frmIngreso()
        {
            InitializeComponent();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }

        private void frmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia = null;
        }

        private void BuscarProveedorutton_Click(object sender, EventArgs e)
        {
            frmVistaProveedorIngreso vista = new frmVistaProveedorIngreso();
            vista.ShowDialog();
        }

        private void BuscarArticulobutton1_Click(object sender, EventArgs e)
        {
            frmVistaArticuloIngreso vista = new frmVistaArticuloIngreso();
            vista.ShowDialog();
        }
    }
}
