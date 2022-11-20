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
    public partial class VerVentas : Form
    {
        Conexion conexionDb = new Conexion();

        public VerVentas()
        {
            InitializeComponent();
        }
        private void VerVentas_Load(object sender, EventArgs e)
        {
            // Al cargarse el form se cargara todas las ventas
            // y solo se mostrara el la vista en la que se vea unicamente el listado de las ventas
            CargarTodasLasVentas();
            dtpGetDate.Value = DateTime.Now;
            txtCodigoBusqueda.Visible = true;
            txtCodigoBusqueda.Enabled = true;
            cmbEstadoVenta.Enabled = false;
            cmbEstadoVenta.Visible = false;
            dtpGetDate.Enabled = false;
            dtpGetDate.Visible = false;

        }
        // Mediante una funcion de la clase de conexion se llenara el datagridview de ventas
        private void CargarTodasLasVentas()
        {
            conexionDb.llenarDGV(dgvVentas, "SELECT dbo.Venta.IdVenta AS [Numero Venta], dbo.Venta.FechaVenta AS [Fecha Venta], " +
                "dbo.Venta.Estado " +
                "FROM dbo.Venta " +
                "GROUP BY dbo.Venta.IdVenta, dbo.Venta.FechaVenta, dbo.Venta.Estado");
        }        
        // Mediante una funcion de la clase de conexion se llenara el datagridview segun la condicion que se seleccione
        private void CargarVentaCondicion(string Condicion, string CodigoBusqueda)
        {
            // Segun el filtro seleccionado en el combobox se tomara la condicion
            if (Condicion == "Fecha de Venta")
            {
                Condicion = "FechaVenta";
            }
            else if (Condicion == "Estado de Venta")
            {
                Condicion = "Estado";
            }
            else
            {
                Condicion = "IdVenta";
            }

            // Se llena el datagrid con la condición y el codigo de busqueda
            conexionDb.llenarDGV(dgvVentas, "SELECT dbo.Venta.IdVenta AS [Numero Venta], dbo.Venta.FechaVenta AS [Fecha Venta], " +
                "dbo.Venta.Estado FROM dbo.Venta " +
                "WHERE dbo.Venta."+Condicion+" = '"+CodigoBusqueda+"' " +
                "GROUP BY dbo.Venta.IdVenta, dbo.Venta.FechaVenta, dbo.Venta.Estado");


        }
        private void cmbFiltroBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se validara que el combobox tenga un elemento seleccionado
            // al haber un cambio los campos del filtro cambiaran acorde al filtro seleccionado
            if (cmbFiltroBusqueda.SelectedItem != null)
            {

                string Filtro = cmbFiltroBusqueda.SelectedItem.ToString();
                if (Filtro == "Fecha de Venta")
                {
                    txtCodigoBusqueda.Visible = false;
                    txtCodigoBusqueda.Enabled = false;
                    cmbEstadoVenta.Enabled = false;
                    cmbEstadoVenta.Visible = false;
                    dtpGetDate.Value = DateTime.Now;
                    dtpGetDate.Enabled = true;
                    dtpGetDate.Visible = true;
                }
                else if (Filtro == "Estado de Venta")
                {
                    txtCodigoBusqueda.Visible = false;
                    txtCodigoBusqueda.Enabled = false;
                    cmbEstadoVenta.SelectedIndex = -1;
                    cmbEstadoVenta.Enabled = true;
                    cmbEstadoVenta.Visible = true;
                    dtpGetDate.Enabled = false;
                    dtpGetDate.Visible = false;
                }
                else
                {
                    txtCodigoBusqueda.Clear();
                    txtCodigoBusqueda.Visible = true;
                    txtCodigoBusqueda.Enabled = true;
                    cmbEstadoVenta.Enabled = false;
                    cmbEstadoVenta.Visible = false;
                    dtpGetDate.Enabled = false;
                    dtpGetDate.Visible= false;  
                }
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            // Se recargaran las ventas y se reiniciaran los campos
            CargarTodasLasVentas();
            cmbFiltroBusqueda.SelectedIndex = -1;
            cmbEstadoVenta.SelectedIndex = -1;
            txtCodigoBusqueda.Visible = true;
            txtCodigoBusqueda.Enabled = true;
            cmbEstadoVenta.Enabled = false;
            cmbEstadoVenta.Visible = false;
            dtpGetDate.Enabled = false;
            dtpGetDate.Visible = false;
            dtpGetDate.Value = DateTime.Now;
            txtCodigoBusqueda.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Segun el filtro seleccionado se mandara a llamar la funcion de cargarventa con condicion de una manera diferente.
            if (cmbFiltroBusqueda.SelectedIndex != -1)
            {
                switch (cmbFiltroBusqueda.SelectedItem)
                {
                    case "Fecha de Venta":
                        CargarVentaCondicion(cmbFiltroBusqueda.SelectedItem.ToString(), dtpGetDate.Value.ToString("yyyy-MM-dd"));
                        break;

                    case "Numero de Venta":
                        if(txtCodigoBusqueda.Text != string.Empty)
                        {
                            CargarVentaCondicion(cmbFiltroBusqueda.SelectedItem.ToString(), txtCodigoBusqueda.Text);
                        }
                        else
                        {
                            MessageBox.Show("Debe escribir el codigo de busqueda seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case "Estado de Venta":
                        if (cmbEstadoVenta.SelectedIndex != -1)
                        {
                                CargarVentaCondicion(cmbFiltroBusqueda.SelectedItem.ToString(), cmbEstadoVenta.SelectedItem.ToString());

                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el estado de la venta a buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        break;

                    default:
                        MessageBox.Show("Debe seleccionar de que manera filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar de que manera filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Al hacer doble click sobre una venta el panel donde se listan todas las ventas se ocultara
        //  y se mostrara el panel donde estara el detalle de venta de la venta a la que se le dio doble click
        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PanelVentas.Enabled = false;
            PanelVentas.Visible= false;
            PanelDetalleVenta.Visible = true;
            PanelDetalleVenta.Enabled = true;
           
            txtNumVenta.Text = dgvVentas.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (dgvVentas.Rows[e.RowIndex].Cells[2].Value.ToString() != "Cancelada")
            {
                txtTotalPagar.Text = conexionDb.obtenerVariableDecimal("SELECT SUM([PrecioSugerido] * [Cantidad]) FROM [dbo].[DetalleVenta] WHERE [IdVenta] = "+ Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells[0].Value) + " and [Estado] <> 'Cancelada'").ToString();
            }
            else
            {
                txtTotalPagar.Text = "0.00";
            }
            conexionDb.llenarDGV(dgvDetalleVenta, "SELECT dbo.Producto.CodigoProducto AS Codigo, dbo.Producto.NombreProducto AS Producto, dbo.DetalleVenta.PrecioSugerido AS Precio, " +
                "dbo.DetalleVenta.Cantidad, dbo.DetalleVenta.Estado, \r\n(dbo.DetalleVenta.PrecioSugerido * dbo.DetalleVenta.Cantidad) AS SubTotal " +
                "FROM     dbo.DetalleVenta INNER JOIN dbo.Producto ON dbo.DetalleVenta.IdProducto = dbo.Producto.IdProducto " +
                "WHERE dbo.DetalleVenta.IdVenta = " + Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells[0].Value));
            dtpFecha.Value = Convert.ToDateTime(dgvVentas.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            PanelVentas.Enabled = true;
            PanelVentas.Visible = true;
            PanelDetalleVenta.Visible = false;
            PanelDetalleVenta.Enabled = false;
            txtNumVenta.Clear();
            txtTotalPagar.Clear();
            dgvDetalleVenta.DataSource = null; 
        }

        private void btnReporte_MouseHover(object sender, EventArgs e)
        {
            btnReporte.ForeColor = Color.White;
        }

        private void btnReporte_MouseLeave(object sender, EventArgs e)
        {
            btnReporte.ForeColor = Color.FromArgb(32, 43, 76);  
        }

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.ForeColor = Color.White;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.ForeColor = Color.FromArgb(32, 43, 76);

        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnVerTodo_MouseHover(object sender, EventArgs e)
        {
            btnVerTodo.ForeColor = Color.White;
        }

        private void btnVerTodo_MouseLeave(object sender, EventArgs e)
        {
            btnVerTodo.ForeColor = Color.FromArgb(32, 43, 76);
        }
    }
}
