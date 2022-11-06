using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PulperiaPY.Utilidades;

namespace PulperiaPY
{
    public partial class Venta : Form
    {
        CultureInfo culturaHN = new CultureInfo("es-HN");
        Conexion conexionDb = new Conexion();
        string accion = "Agregar";
        string accionVenta = "Nueva Venta";

        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            accionVenta = "Nueva Venta";
            lblTipoAccion.Text = accionVenta;
            dtpFecha.Value = DateTime.Now;
            txtCambio.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            reiniciarNumVenta();
            btnBuscarVenta.Enabled = false;
            btnBuscarVenta.Visible = false;
            btnAgregarProducto.Text = "Agregar Producto";
        }

        private void txtNumVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPagaCon_TextChanged(object sender, EventArgs e)
        {
            decimal monto = 0, cambio = 0, cantidadPago = 0;

            if (txtPagaCon.Text != string.Empty)
            {


                if (txtPagaCon.Text.Length >= 1 && txtPagaCon.Text[0] == '.')
                {

                    int select = txtPagaCon.SelectionStart;
                    txtPagaCon.Text = txtPagaCon.Text.Insert(0, "0");
                    txtPagaCon.SelectionStart = ++select;

                }
                else
                {
                    monto = Convert.ToDecimal(txtTotalPagar.Text);
                    cantidadPago = Convert.ToDecimal(txtPagaCon.Text);
                    if (cantidadPago >= 0 && cantidadPago >= monto)
                    {
                        txtPagaCon.ForeColor = Color.Green;
                        cambio = cantidadPago - monto;
                        txtCambio.Text = cambio.ToString("N2", culturaHN);
                    }
                    else
                    {
                        txtPagaCon.ForeColor = Color.Red;
                    }
                }

            }
            else
            {
                txtCambio.Text = "0.00";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProductosVenta frm = new ProductosVenta();
            frm.FormClosing += ProductosVenta_FormClosing;
            frm.Show();
        }

        public void ProductosVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtCodProducto.Text = clsVariableGlobales.CodigoProductoV;
            txtNombreProducto.Text = clsVariableGlobales.NombreProductoV;
            txtPrecio.Text = clsVariableGlobales.PrecioProductoV.ToString();
            txtStock.Text = clsVariableGlobales.StockProductoV.ToString();
            clsVariableGlobales.CodigoProductoV = "";
            clsVariableGlobales.NombreProductoV = "";
            clsVariableGlobales.PrecioProductoV = 0;
            clsVariableGlobales.StockProductoV = 0;
            nudCantidad.Value = 1;
            accion = "Agregar";
            btnAgregarProducto.Text = "Agregar Producto";

        }

        private void totalPago()
        {
            decimal montoPagar = 0;


            for (int i = 0; i < dgvDetalleVenta.Rows.Count; i++)
            {
                montoPagar += Convert.ToDecimal(dgvDetalleVenta.Rows[i].Cells["SubTotal"].Value);
            }

            txtTotalPagar.Text = montoPagar.ToString("N2", culturaHN);

        }

        private void AgregarProductoAlDetalle()
        {
            bool existe;
            existe = false;
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                dgvDetalleVenta.Rows.Insert(0, txtCodProducto.Text, txtNombreProducto.Text, txtPrecio.Text, nudCantidad.Value, (Convert.ToDecimal(txtPrecio.Text) * Convert.ToInt32(nudCantidad.Value)), "Eliminar");
            }
            else
            {
                foreach (DataGridViewRow Row in dgvDetalleVenta.Rows)
                {
                    string CodProdEvaluar = Convert.ToString(Row.Cells[0].Value);

                    if (CodProdEvaluar == txtCodProducto.Text)
                    {
                        int nuevaCantidad = Convert.ToInt32(Row.Cells[3].Value) + Convert.ToInt32(nudCantidad.Value);
                        if (Convert.ToInt32(txtStock.Text) >= nuevaCantidad)
                        {
                            Row.Cells[3].Value = nuevaCantidad;
                            Row.Cells[4].Value = Convert.ToInt32(Row.Cells[3].Value) * Convert.ToDecimal(Row.Cells[2].Value);
                            existe = true;
                        }
                        else
                        {
                            existe = true;
                            MessageBox.Show("No hay suficiente stock disponible", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }          
                }
                if (!existe)
                {
                        dgvDetalleVenta.Rows.Insert(dgvDetalleVenta.Rows.Count, txtCodProducto.Text, txtNombreProducto.Text, txtPrecio.Text, nudCantidad.Value, (Convert.ToDecimal(txtPrecio.Text) * Convert.ToInt32(nudCantidad.Value)), "Eliminar");
                }
            }
        
            ActualizarTotalPagar();
            

        }

        private void ActualizarProductoDetalle()
        {
            foreach (DataGridViewRow Row in dgvDetalleVenta.Rows)
            {
                string CodProdEvaluar = Convert.ToString(Row.Cells[0].Value);

                if (CodProdEvaluar == txtCodProducto.Text)
                {
                    
                    Row.Cells[2].Value = txtPrecio.Text;
                    Row.Cells[3].Value = nudCantidad.Value;
                    Row.Cells[4].Value = Convert.ToInt32(Row.Cells[3].Value) * Convert.ToDecimal(Row.Cells[2].Value);
                }
            }
            ActualizarTotalPagar();
        }

        private void ActualizarTotalPagar()
        {
            Decimal totalPagar = 0;
            
            foreach(DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                totalPagar += Convert.ToDecimal(row.Cells[4].Value);
            }
            txtTotalPagar.Text = totalPagar.ToString();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodProducto.Text != string.Empty && txtNombreProducto.Text != string.Empty && txtPrecio.Text != string.Empty 
                && txtStock.Text != string.Empty)
            {
                if (accion == "Agregar")
                {
                    if(nudCantidad.Value <= Convert.ToInt32(txtStock.Text))
                    {
                        AgregarProductoAlDetalle();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock disponible", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if (nudCantidad.Value <= Convert.ToInt32(txtStock.Text))
                    {
                        ActualizarProductoDetalle();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock disponible", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe buscar y seleccionar el producto que agregara\nO asegurarse de que todos los campos estan completos", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private void reiniciarNumVenta()
        {
            int NumVenta;
            NumVenta = conexionDb.obtenerVariableEntera("SELECT [IdVenta] FROM [dbo].[Venta] WHERE [IdVenta]=(SELECT max([IdVenta]) FROM [dbo].[Venta]);");
            NumVenta += 1;
            txtNumVenta.Text = NumVenta.ToString(); 

        }

        public void limpiarTextBox(Control cont)
        {
            foreach (Control control in cont.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control is MaskedTextBox)
                    control.Text = string.Empty;
            }
        }

        private void limpiarVenta()
        {
            limpiarTextBox(gbInformacionVenta);
            limpiarTextBox(gbInformacionProducto);
            limpiarTextBox(panelTotales);
            dgvDetalleVenta.Rows.Clear();
            reiniciarNumVenta();
            dtpFecha.Value = DateTime.Now;
            txtCambio.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            reiniciarNumVenta();

        }

        private int SeleccionarStockProducto()
        {
            return conexionDb.obtenerVariableEntera("SELECT dbo.Inventario.CantidadDisponible AS [En Stock] " +
                "FROM dbo.Inventario " +
                "INNER JOIN dbo.Producto ON dbo.Inventario.IdProducto = dbo.Producto.IdProducto " +
                "Where dbo.Producto.CodigoProducto = "+ txtCodProducto.Text +";");
        }

        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                dgvDetalleVenta.Rows.RemoveAt(dgvDetalleVenta.CurrentRow.Index);
                ActualizarTotalPagar();
            }
            else
            {
                limpiarTextBox(gbInformacionProducto);
                accion = "Actualizar";
                btnAgregarProducto.Text = "Editar Producto";
                txtCodProducto.Text = dgvDetalleVenta.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreProducto.Text = dgvDetalleVenta.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrecio.Text = dgvDetalleVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
                nudCantidad.Value = Convert.ToInt32(dgvDetalleVenta.Rows[e.RowIndex].Cells[3].Value);
                txtStock.Text = SeleccionarStockProducto().ToString();
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            accionVenta = "Nueva Venta";
            lblTipoAccion.Text = accionVenta;
            limpiarVenta();
            txtNumVenta.ReadOnly = true;
            btnBuscarVenta.Enabled = false;
            btnBuscarVenta.Visible = false;
            
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            accionVenta = "Editar Venta";
            lblTipoAccion.Text = accionVenta;
            limpiarVenta();
            txtNumVenta.ReadOnly = false;
            btnBuscarVenta.Enabled = true;
            btnBuscarVenta.Visible = true;
            txtNumVenta.Clear();
        }

        private void RealizarVenta()
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            int TotalProductosDetalle = dgvDetalleVenta.Rows.Count;
            string detalleVenta = "";
            for(int i = 0; TotalProductosDetalle > i; i++)
            {
                if(i == 0)
                {
                    detalleVenta += "('"+txtNumVenta.Text+ "',(SELECT idProducto from [dbo].[Producto] WHERE CodigoProducto = '" + dgvDetalleVenta.Rows[i].Cells[0].Value.ToString() + "'),'" + dgvDetalleVenta.Rows[i].Cells[3].Value.ToString() + "','" + dgvDetalleVenta.Rows[i].Cells[2].Value.ToString() + "','Realizado')";
                }
                else
                {
                    detalleVenta += ",('" + txtNumVenta.Text + "',(SELECT idProducto from [dbo].[Producto] WHERE CodigoProducto = '" + dgvDetalleVenta.Rows[i].Cells[0].Value.ToString() + "'),'" + dgvDetalleVenta.Rows[i].Cells[3].Value.ToString() + "','" + dgvDetalleVenta.Rows[i].Cells[2].Value.ToString() + "','Realizado')";

                }
            }
            if (conexionDb.ejecutarComandoSQL("INSERT INTO [dbo].[Venta]([FechaVenta],[Estado]) VALUES('"+fecha+"','Finalizada'); " +
                "INSERT INTO [dbo].[DetalleVenta]([IdVenta],[IdProducto],[Cantidad],[PrecioSugerido],[Estado])" +
                " VALUES" +
                detalleVenta +
                ";"))
            {
                MessageBox.Show("¡Venta Realizada con Exito!", "VENTA FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al Realizar la Venta!", "ERROR EN LA VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count > 0)
            {
                if (txtPagaCon.Text != String.Empty)
                {
                    if (Convert.ToDecimal(txtTotalPagar.Text) <= Convert.ToDecimal(txtPagaCon.Text))
                    {
                        RealizarVenta();
                        limpiarVenta();
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar un monto con el que paga\nmayor o igual al Total a pagar ", "Error al realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el monto con el que se pagará", "Error al realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe agregar productos a la venta", "Error al realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
