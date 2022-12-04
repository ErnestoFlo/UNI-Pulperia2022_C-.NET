using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PulperiaPY
{
    public partial class Producto : Form
    {
        Conexion conexion = new Conexion();
        
        public Producto()
        {
            InitializeComponent();
            cargarMarcas();
            cargarCategoria();
            esconder();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarMarcas()
        {
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = conexion.connection;
                SqlCommand sqlComm = new SqlCommand("MostrarMarca", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                DataTable result = new DataTable();
                da.Fill(result);
                marcacb.DisplayMember = "Nombre Marca";
                marcacb.ValueMember = "Codigo Marca";
                marcacb.DataSource = result;
                marcacb.Refresh();
            }
        }

        private void cargarCategoria()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = conexion.connection;
                SqlCommand sqlComm = new SqlCommand("MostrarCategoria", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                DataTable result = new DataTable();
                da.Fill(result);

                categoriacb.DataSource = result;
                categoriacb.DisplayMember = "nombreCategoria";
                categoriacb.ValueMember = "idCategoria";
            }
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void esconder()
        {
            lblCategoria.Visible = false;
            lblMarca.Visible = false;
            btnAgregaNuevo.Visible = false;
            txtCategoria.Visible = false;
            txtMarca.Visible = false;
            btnCancelarNuevo.Visible=false;
        }

        private void deshabilitar()
        {
            marcacb.Enabled = false;
            categoriacb.Enabled = false;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            btnAgregar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnNM.Enabled = false;
            btnNC.Enabled = false;
        }

        private void habilitar()
        {
            marcacb.Enabled = true;
            categoriacb.Enabled = true;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            btnAgregar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnNM.Enabled = true;
            btnNC.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.ConnectionString = conexion.connection;
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand("InsertarProducto", conn);
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.Parameters.AddWithValue("@IdMarca", Int32.Parse(marcacb.SelectedValue.ToString()));
                    sqlComm.Parameters.AddWithValue("@IdCategoria", Int32.Parse(categoriacb.SelectedValue.ToString()));
                    sqlComm.Parameters.AddWithValue("@CodigoProducto", Int64.Parse(txtCodigo.Text));
                    sqlComm.Parameters.AddWithValue("@NombreProducto", txtNombre.Text);
                    sqlComm.Parameters.AddWithValue("@PrecioSugerido", txtPrecio.Text);
                    sqlComm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Producto agregado con éxito");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deshabilitar();
            lblMarca.Visible = true;
            txtMarca.Visible = true;
            btnAgregaNuevo.Visible = true;
            btnCancelarNuevo.Visible = true;    
        }

        private void btnAgregaNuevo_Click(object sender, EventArgs e)
        {
            if (lblMarca.Visible)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = conexion.connection;
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand("InsertarMarca", conn);
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.Parameters.AddWithValue("@nombreMarca", txtMarca.Text);
                    sqlComm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Marca agregada con éxito");
                    esconder();
                    habilitar();
                    cargarMarcas();
                }
            }else if (lblCategoria.Visible)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = conexion.connection;
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand("InsertarCategoria", conn);
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.Parameters.AddWithValue("@NombreCategoria", txtCategoria.Text);
                    sqlComm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Categoria agregada con éxito");
                    esconder();
                    habilitar();
                    cargarCategoria();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            deshabilitar();
            lblCategoria.Visible = true;
            btnAgregaNuevo.Visible = true;
            txtCategoria.Visible = true;
            btnCancelarNuevo.Visible = true;    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            esconder();
            habilitar();
        }

        private void gbInformacionVenta_Enter(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.White;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnNM_MouseHover(object sender, EventArgs e)
        {
            btnNM.ForeColor = Color.White;
        }

        private void btnNM_MouseLeave(object sender, EventArgs e)
        {
            btnNM.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnNC_MouseHover(object sender, EventArgs e)
        {
            btnNC.ForeColor = Color.White;
        }

        private void btnNC_MouseLeave(object sender, EventArgs e)
        {
            btnNC.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnAgregaNuevo_MouseHover(object sender, EventArgs e)
        {
            btnAgregaNuevo.ForeColor = Color.White;
        }

        private void btnAgregaNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnAgregaNuevo.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnCancelarNuevo_MouseHover(object sender, EventArgs e)
        {
            btnCancelarNuevo.ForeColor = Color.White;
        }

        private void btnCancelarNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.FromArgb(32, 43, 76);
        }
    }
}
