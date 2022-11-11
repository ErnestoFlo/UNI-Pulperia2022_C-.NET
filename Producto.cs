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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
