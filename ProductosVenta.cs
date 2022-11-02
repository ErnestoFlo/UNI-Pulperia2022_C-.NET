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
        }

        private void CargarTodosProductos()
        {
            conexionDb.llenarDGV(dgvListaProductos, "SELECT dbo.Producto.codigoProducto AS [Codigo]," +
                " dbo.Producto.nombreProducto AS Producto, dbo.Marca.nombreMarca AS [Marca], " +
                "dbo.Categoria.nombreCategoria AS [Categoria], dbo.Producto.precioSugerido AS Precio, " +
                "dbo.Inventario.cantidadDisponible AS [En Stock] FROM dbo.Producto " +
                "INNER JOIN dbo.Marca ON dbo.Producto.idMarca = dbo.Marca.idMarca " +
                "INNER JOIN dbo.Categoria ON dbo.Producto.idCategoria = dbo.Categoria.idCategoria " +
                "INNER JOIN dbo.Inventario ON dbo.Producto.idProducto = dbo.Inventario.idProducto");
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


            conexionDb.llenarDGV(dgvListaProductos, "SELECT dbo.Producto.codigoProducto AS [Codigo]," +
                " dbo.Producto.nombreProducto AS Producto, dbo.Marca.nombreMarca AS [Marca], " +
                "dbo.Categoria.nombreCategoria AS [Categoria], dbo.Producto.precioSugerido AS Precio, " +
                "dbo.Inventario.cantidadDisponible AS [En Stock] FROM dbo.Producto " +
                "INNER JOIN dbo.Marca ON dbo.Producto.idMarca = dbo.Marca.idMarca " +
                "INNER JOIN dbo.Categoria ON dbo.Producto.idCategoria = dbo.Categoria.idCategoria " +
                "INNER JOIN dbo.Inventario ON dbo.Producto.idProducto = dbo.Inventario.idProducto where " +
                Condicion +" like '%"+CodigoBusqueda+"%'");
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
    }
}
