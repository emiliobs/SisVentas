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
    public partial class FrmReportesArticulos : Form
    {
        public FrmReportesArticulos()
        {
            InitializeComponent();
        }

        private void FrmReportesArticulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.spMostrarArticulo' table. You can move, or remove it, as needed.
            this.spMostrarArticuloTableAdapter.Fill(this.dsPrincipal.spMostrarArticulo);

            this.reportViewer1.RefreshReport();
        }
    }
}
