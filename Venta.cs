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

namespace PulperiaPY
{
    public partial class Venta : Form
    {
        CultureInfo culturaHN = new CultureInfo("es-HN");
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            txtCambio.Text = "0.00";
            txtTotalPagar.Text = "0.00";
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
            ProductosVenta productosVenta = new ProductosVenta();
            productosVenta.Show();
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

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count < 0)
            {
                if (Convert.ToDecimal(txtTotalPagar.Text) <= Convert.ToDecimal(txtPagaCon.Text))
                {

                }
                else
                {
                    MessageBox.Show("Debe agregar un monto con el que paga\nmayor o igual al Total a pagar ", "Error al realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe agregar productos a la venta","Error al realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
