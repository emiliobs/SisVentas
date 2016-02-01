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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Horalabel.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Horalabel.Text = DateTime.Now.ToString();
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            //Recibe todo los objetos de la tabla trabajador:
            DataTable datos = NTrabajador.Login(this.usuariotextBox.Text, this.PasswordtextBox.Text);

            //evaluo si existe el Usuario en la tabla Trabjadores:
            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene Acsseso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmPrincipal frm = new frmPrincipal();

                //Lleno las variables del objeto frmPrincipal
                frm.IdTrabajador = datos.Rows[0][0].ToString();
                frm.Apellidos    = datos.Rows[0][1].ToString();
                frm.Nombre       = datos.Rows[0][2].ToString();
                frm.Acceso       = datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();
            }

        }
    }
}
