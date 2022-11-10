using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulperiaPY
{
    public partial class frmMenuPrincipal : Form
    {
        System.Drawing.Color activo = Color.FromArgb(75, 158, 253);
        System.Drawing.Color inactivo = Color.FromArgb(34, 43, 76);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            btnInventario.BackColor = activo;
            btnCompras.BackColor = inactivo;
            btnProductos.BackColor = inactivo;
            btnProveedores.BackColor = inactivo;
            btnUsuarios.BackColor = inactivo;
            btnVentas.BackColor = inactivo;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnInventario.BackColor = inactivo;
            btnCompras.BackColor = inactivo;
            btnProductos.BackColor = activo;
            btnProveedores.BackColor = inactivo;
            btnUsuarios.BackColor = inactivo;
            btnVentas.BackColor = inactivo;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnInventario.BackColor = inactivo;
            btnCompras.BackColor = inactivo;
            btnProductos.BackColor = inactivo;
            btnProveedores.BackColor = inactivo;
            btnUsuarios.BackColor = activo;
            btnVentas.BackColor = inactivo;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            btnInventario.BackColor = inactivo;
            btnCompras.BackColor = inactivo;
            btnProductos.BackColor = inactivo;
            btnProveedores.BackColor = activo;
            btnUsuarios.BackColor = inactivo;
            btnVentas.BackColor = inactivo;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            btnInventario.BackColor = inactivo;
            btnCompras.BackColor = activo;
            btnProductos.BackColor = inactivo;
            btnProveedores.BackColor = inactivo;
            btnUsuarios.BackColor = inactivo;
            btnVentas.BackColor = inactivo;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnInventario.BackColor = inactivo;
            btnCompras.BackColor = inactivo;
            btnProductos.BackColor = inactivo;
            btnProveedores.BackColor = inactivo;
            btnUsuarios.BackColor = inactivo;
            btnVentas.BackColor = activo;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelLateral.Size.Width == 158)
            {
                panelLateral.Width = 47;
                btnPerfil2.Visible = true;
                btnCerrarSesion.Visible = false;
                btnCerrarSesion2.Visible = true;
            }
            else
            {
                panelLateral.Width = 158;
                btnPerfil2.Visible = false;
                btnCerrarSesion.Visible = true;
                btnCerrarSesion2.Visible = false;
            }
        }
    }
}
