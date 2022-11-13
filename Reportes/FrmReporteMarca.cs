using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulperiaPY.Reportes
{
    public partial class FrmReporteMarca : Form
    {
        public FrmReporteMarca()
        {
            InitializeComponent();
        }

        private void FrmReporteMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsSistema.Marca' table. You can move, or remove it, as needed.
            this.MarcaTableAdapter.Fill(this.DsSistema.Marca);

            this.reportViewer1.RefreshReport();
        }
    }
}
