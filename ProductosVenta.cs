using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PulperiaPY.Utilidades;

namespace PulperiaPY
{
    public partial class ProductosVenta : Form
    {
        Conexion conexionDb = new Conexion();
        public ProductosVenta()
        {
            InitializeComponent();
        }

        private void ProductosVenta_Load(object sender, EventArgs e)
        {
            CargarTodosProductos();
            moverForm();

            clsVariableGlobales.CodigoProductoV = "";
            clsVariableGlobales.NombreProductoV = "";
            clsVariableGlobales.PrecioProductoV = 0;
            clsVariableGlobales.StockProductoV = 0;
        }

        private void MoveForm()
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.dgvListaProductos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
        }

        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        // función privada usada para mover el formulario actual

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }


        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            moverForm();
        }

        private void CargarTodosProductos()
        {
            conexionDb.llenarDGV(dgvListaProductos, "SELECT dbo.Producto.codigoProducto AS [Codigo]," +
                " dbo.Producto.nombreProducto AS [Producto], dbo.Marca.nombreMarca AS [Marca], " +
                "dbo.Categoria.nombreCategoria AS [Categoria], dbo.Producto.precioSugerido AS Precio, " +
                "dbo.Inventario.cantidadDisponible AS [En Stock] FROM dbo.Producto " +
                "INNER JOIN dbo.Marca ON dbo.Producto.idMarca = dbo.Marca.idMarca " +
                "INNER JOIN dbo.Categoria ON dbo.Producto.idCategoria = dbo.Categoria.idCategoria " +
                "INNER JOIN dbo.Inventario ON dbo.Producto.idProducto = dbo.Inventario.idProducto " +
                "WHERE dbo.Producto.Estado != 0 or dbo.Inventario.CantidadDisponible > 0");
        }

        private void CargarProductosCondicion(string Condicion, string CodigoBusqueda)
        {
            if(Condicion == "Nombre del Producto")
            {
                Condicion = "nombreProducto";
            }
            else if (Condicion == "Codigo")
            {
                Condicion = "codigoProducto";
            }
            else if (Condicion == "Marca")
            {
                Condicion = "nombreMarca";
            }  
            else if (Condicion == "Categoria")
            {
                Condicion = "nombreCategoria";
            }


            conexionDb.llenarDGV(dgvListaProductos, "SELECT dbo.Producto.codigoProducto AS [Codigo], " +
                "dbo.Producto.nombreProducto AS Producto, dbo.Marca.nombreMarca AS [Marca], " +
                "dbo.Categoria.nombreCategoria AS [Categoria], dbo.Producto.precioSugerido AS Precio, " +
                "dbo.Inventario.cantidadDisponible AS [En Stock] FROM dbo.Producto " +
                "INNER JOIN dbo.Marca ON dbo.Producto.idMarca = dbo.Marca.idMarca " +
                "INNER JOIN dbo.Categoria ON dbo.Producto.idCategoria = dbo.Categoria.idCategoria " +
                "INNER JOIN dbo.Inventario ON dbo.Producto.idProducto = dbo.Inventario.idProducto " +
                "WHERE " +
                Condicion +" like '%"+CodigoBusqueda+"%' and " +
                "(dbo.Producto.Estado != 0 or dbo.Inventario.CantidadDisponible > 0);");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbFiltroBusqueda.SelectedIndex != -1)
            {
                if (txtCodigoBusqueda.Text != string.Empty)
                {
                    CargarProductosCondicion(cmbFiltroBusqueda.SelectedItem.ToString(), txtCodigoBusqueda.Text);
                }
                else
                {
                    MessageBox.Show("Debe escribir el codigo de busqueda seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar de que manera filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarTodosProductos();
            cmbFiltroBusqueda.SelectedIndex = -1;
            txtCodigoBusqueda.Clear();
        }

        private void dgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsVariableGlobales.CodigoProductoV = dgvListaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            clsVariableGlobales.NombreProductoV = dgvListaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            clsVariableGlobales.PrecioProductoV = Convert.ToInt32(dgvListaProductos.Rows[e.RowIndex].Cells[4].Value);
            clsVariableGlobales.StockProductoV = Convert.ToInt32(dgvListaProductos.Rows[e.RowIndex].Cells[5].Value);
            this.Close();

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
