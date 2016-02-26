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
    public partial class FrmReporteFactura : Form
    {

        private int idVenta;



        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        public int IdVenta
        {
            get
            {
                return idVenta;
            }

            set
            {
                idVenta = value;
            }
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dsPrincipal.spReporteFactura' table. You can move, or remove it, as needed.
            try
            {
                this.spReporteFacturaTableAdapter.Fill(this.dsPrincipal.spReporteFactura, IdVenta);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                this.reportViewer1.RefreshReport();
            }
            
        }
    }
}
