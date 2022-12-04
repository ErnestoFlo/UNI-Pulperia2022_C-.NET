using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PulperiaPY.CapaDatos;

namespace PulperiaPY
{
    public partial class Inventario : Form
    {
        //conexion2 conexion = new conexion2();
        Conexion conexion = new Conexion();

        public Inventario()
        {
            InitializeComponent();
        }

        private void ListarProducto()
        {
            ClsProductos objProd = new ClsProductos();
            cbxProducto.DataSource = objProd.ListarProductos();
            cbxProducto.DisplayMember = "NombreProducto";
            cbxProducto.ValueMember = "IdProducto";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ListarInventario();
            ListarProducto();
        }

        private void ListarInventario()
        {
            ClsProductos objprod = new ClsProductos();
            dataGridView1.DataSource = objprod.ListarInventario();
        }

        ClsProductos objproducto = new ClsProductos();

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" )
            {
                conexion.AbrirConexion();
                //SqlCommand cmd1 = new SqlCommand("select nombreMarca from Marca where nombreMarca=@parm1", conexion.Conectar);
                SqlCommand cmd1 = new SqlCommand("select IdInventario as 'Codigo' , Producto.NombreProducto as 'Nombre Producto' , CantidadDisponible as 'Cantidad Disponible' from Inventario INNER JOIN Producto ON Producto.IdProducto = Inventario.IdProducto where  nombreProducto=@parm1", conexion.Conectar);
                cmd1.Parameters.AddWithValue("parm1", cbxProducto.Text);
                SqlDataReader verificar;
                conexion.AbrirConexion();
                verificar = cmd1.ExecuteReader();
                if (verificar.Read())
                {
                    MessageBox.Show("Producto ya existe ya existe");
                    conexion.CerrarConexion();
                }
                else
                {
                    conexion.CerrarConexion();

                    objproducto.InsertarInventario(
                        Convert.ToInt32(cbxProducto.SelectedValue),
                        Convert.ToInt32(txtCantidad.Text)
                        );
                    MessageBox.Show("Se inserto correctamente");
                    ListarInventario();
                }
            }
            else
            {
                MessageBox.Show("Campo Vacio");
            }
            ListarInventario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoInventario.Clear();
            txtCantidad.Clear();
            cbxProducto.ResetText();
            txtBuscarInventario.Clear();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                txtCodigoInventario.Text = dataGridViewRow.Cells[0].Value.ToString();
                cbxProducto.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtCantidad.Text = dataGridViewRow.Cells[2].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigoInventario.Text != "" && txtCantidad.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec UpdateInventario @IdInventario, @CantidadDisponible", conexion.Conectar);
                cmd.Parameters.AddWithValue("@IdInventario", txtCodigoInventario.Text);
                cmd.Parameters.AddWithValue("@CantidadDisponible", txtCantidad.Text);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Inventario Actualizada");
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Error actualizar Inventario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Vacios \n" + ex.Message);
                }
                ListarInventario();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoInventario.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec DeleteInventario @IdInventario", conexion.Conectar);
                cmd.Parameters.AddWithValue("@IdInventario", txtCodigoInventario.Text);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Inventario Borrada");
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Error borrar Inventario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Vacios \n" + ex.Message);
                }
                ListarInventario();
            }
            else
            {
                MessageBox.Show("Codigo Inventario Vacio");
            }
        }

        private void txtBuscarInventario_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand sd = new SqlCommand("select idMarca as 'Codigo Marca', nombreMarca as 'Nombre Marca' from Inventario where nombreMarca like '%" + txtBuscarInventario.Text + "%'", conexion.Conectar);

            SqlCommand sd = new SqlCommand("select IdInventario as 'Codigo' , Producto.NombreProducto as 'Nombre Producto' , CantidadDisponible as 'Cantidad Disponible' from Inventario INNER JOIN Producto ON Producto.IdProducto = Inventario.IdProducto where NombreProducto like '%" + txtBuscarInventario.Text + "%'", conexion.Conectar);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sd;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.CerrarConexion();
        }

        private void btnMostrarMarca_Click(object sender, EventArgs e)
        {
            marcas mostrarMarca = new marcas();
            mostrarMarca.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.FrmInventario Reportes = new Reportes.FrmInventario();
            Reportes.ShowDialog();
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Show();
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.White;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.White; 
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.White;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnReporte_MouseHover(object sender, EventArgs e)
        {
            btnReporte.ForeColor = Color.White; 
        }

        private void btnReporte_MouseLeave(object sender, EventArgs e)
        {
            btnReporte.ForeColor = Color.FromArgb(32, 43, 76);
        }
    }
}
