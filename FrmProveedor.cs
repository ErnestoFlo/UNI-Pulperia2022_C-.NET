using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PulperiaPY
{
    public partial class FrmProveedor : Form
    {
        Conexion conexionDb = new Conexion();
        public int estadoBit { get; set; }
        public FrmProveedor()
        {
            InitializeComponent();
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            conexionDb.llenarDGV(dgvProveedores, "Execute verProveedoresACT");
        }
        private void CargarProveedoresIna()
        {
            conexionDb.llenarDGV(dgvProveedores, "Execute verProveedoresINA");
        }
        private void CargarTodosProveedores()
        {
            conexionDb.llenarDGV(dgvProveedores, "Execute verTodosProveedores");
        }
        private void limpiarSel()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)

                {

                    c.Text = "";

                    //Enfoco en el primer TextBox

                    this.txbIdProv.Focus();

                }

            }
            cmbEstProv.SelectedIndex = 0;
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            cmbEstProv.SelectedIndex = 0;
            cmbFiltroProv.SelectedIndex = 0;
        }

        private void btnAddProv_Click(object sender, EventArgs e)
        {
            string message = "¿Está seguro que desea insertar el proveedor?";
            string caption = "Comprobación";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if(txbIdProv.Text != "")
            {
                MessageBox.Show("El proveedor ya se encuentra insertado", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (txbNameProv.Text != "" && txbTelProv.Text != "" && txbDirProv.Text != "" && cmbEstProv.SelectedIndex != 0)
            {
                string nombreProov = string.Format(txbNameProv.Text);
                string telefono = string.Format(txbTelProv.Text);
                string direccion = string.Format(txbDirProv.Text);

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (conexionDb.ejecutarComandoSQL("Execute crearProveedor '" + nombreProov + "' , '" + telefono + "' , '" + direccion + "', '" + estadoBit + "' "))
                    {
                        MessageBox.Show("Proveedor insertado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar proveedor", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    limpiarSel();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos solicitados", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbIdProv.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                txbNameProv.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                txbTelProv.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                txbDirProv.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
                string valorCel = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                bool numCel = Convert.ToBoolean(valorCel);
                if (numCel)
                {
                    cmbEstProv.SelectedIndex = 1;
                }
                else
                {
                    cmbEstProv.SelectedIndex = 2;
                }
            }
            catch
            {
                MessageBox.Show("Error al seleccionar proveedor", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleProv_Click(object sender, EventArgs e)
        {
            limpiarSel();
        }

        private void btnUpdProv_Click(object sender, EventArgs e)
        {
            string nombreProov = string.Format(txbNameProv.Text);
            string telefono = string.Format(txbTelProv.Text);
            string direccion = string.Format(txbDirProv.Text);

            string message = "¿Está seguro que desea actualizar el proveedor?";
            string caption = "Comprobación";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (txbNameProv.Text != "" && txbTelProv.Text != "" && txbDirProv.Text != "" && cmbEstProv.SelectedIndex != 0)
            {
                int idProv = Int32.Parse(txbIdProv.Text);
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (conexionDb.ejecutarComandoSQL("Execute actualizarProveedor '" + idProv + "' , '" + nombreProov + "' , '" + telefono + "' , '" + direccion + "', '" + estadoBit + "' "))
                    {
                        MessageBox.Show("Proveedor actualizado correctamente", "Actualizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar proveedor", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    limpiarSel();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos solicitados", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearProv_Click(object sender, EventArgs e)
        {
            string estadoFil = cmbFiltroProv.Text;

            if (txbSearProv.Text != "" && estadoFil == "Activos")
            {
                string nombreProov = string.Format(txbSearProv.Text);
                if (conexionDb.llenarDGV(dgvProveedores, "Execute buscarProveedor '" + nombreProov + "'"))
                {
                    //Proveedor encontrado
                }
                else
                {
                    MessageBox.Show("Error al buscar proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txbSearProv.Text != "" && estadoFil == "Inactivos")
            {
                string nombreProov = string.Format(txbSearProv.Text);
                if (conexionDb.llenarDGV(dgvProveedores, "Execute buscarProveedorIna '" + nombreProov + "'"))
                {
                    //Proveedor encontrado
                }
                else
                {
                    MessageBox.Show("Error al buscar proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txbSearProv.Text != "" && estadoFil == "Todos")
            {
                string nombreProov = string.Format(txbSearProv.Text);
                if (conexionDb.llenarDGV(dgvProveedores, "Execute buscarProveedorAll '" + nombreProov + "'"))
                {
                    //Proveedor encontrado
                }
                else
                {
                    MessageBox.Show("Error al buscar proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre del proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSearProv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEstProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cmbEstProv.Text;

            if (estado == "Activo")
            {
                estadoBit = 1;
            }
            else
            {
                estadoBit = 0;
            }
        }

        private void btnDelProve_Click(object sender, EventArgs e)
        {
            string message = "¿Está seguro que desea eliminar el proveedor?";
            string caption = "Comprobación";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (txbIdProv.Text != "")
            {
                int idProv = Int32.Parse(txbIdProv.Text);
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (conexionDb.ejecutarComandoSQL("Execute eliminarProveedor '" + idProv + "'"))
                    {
                        MessageBox.Show("Proveedor eliminado correctamente", "Eliminado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar proveedor", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    limpiarSel();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltroProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSearProv.Text = "";
            int estadoFil = cmbFiltroProv.SelectedIndex;

            if (estadoFil == 0)
            {
                CargarProveedores();
            }
            else if(estadoFil == 1)
            {
                CargarProveedoresIna();
            }
            else
            {
                CargarTodosProveedores();
            }
        }

        private void btnAddProv_MouseHover(object sender, EventArgs e)
        {
            btnAddProv.ForeColor = Color.White;
        }

        private void btnAddProv_MouseLeave(object sender, EventArgs e)
        {
            btnAddProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnUpdProv_MouseHover(object sender, EventArgs e)
        {
            btnUpdProv.ForeColor = Color.White;
        }

        private void btnUpdProv_MouseLeave(object sender, EventArgs e)
        {
            btnUpdProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnDelProve_MouseHover(object sender, EventArgs e)
        {
            btnDelProve.ForeColor = Color.White;
        }

        private void btnDelProve_MouseLeave(object sender, EventArgs e)
        {
            btnDelProve.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnCleProv_MouseHover(object sender, EventArgs e)
        {
            btnCleProv.ForeColor = Color.White;
        }

        private void btnCleProv_MouseLeave(object sender, EventArgs e)
        {
            btnCleProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnSearProv_MouseHover(object sender, EventArgs e)
        {
            btnSearProv.ForeColor = Color.White;
        }

        private void btnSearProv_MouseLeave(object sender, EventArgs e)
        {
            btnSearProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnReporte_MouseHover(object sender, EventArgs e)
        {
            btnReporte.ForeColor = Color.White;
        }

        private void btnReporte_MouseLeave(object sender, EventArgs e)
        {
            btnReporte.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
