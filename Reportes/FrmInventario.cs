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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsSistema.Inventario' table. You can move, or remove it, as needed.
            this.InventarioTableAdapter.Fill(this.DsSistema.Inventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
