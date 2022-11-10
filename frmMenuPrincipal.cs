using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.CodeDom;
using System.Runtime.InteropServices.ComTypes;

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
            abrirFormulario<ListadoUsuarios>();


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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnCerrarSesion2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void abrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            abrirFormulario<Usuario>();
        }
    }
}
