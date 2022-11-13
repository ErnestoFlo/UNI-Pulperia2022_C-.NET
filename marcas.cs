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

namespace PulperiaPY
{
    public partial class marcas : Form
    {
        public string operacion;

        public marcas()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void marcas_Load(object sender, EventArgs e)
        {
            mostrarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreMarca.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd1 = new SqlCommand("select nombreMarca from Marca where nombreMarca=@parm1", conexion.Conectar);
                cmd1.Parameters.AddWithValue("parm1", txtNombreMarca.Text);
                SqlDataReader verificar;
                conexion.AbrirConexion();
                verificar = cmd1.ExecuteReader();
                if (verificar.Read())
                {
                    MessageBox.Show("Marca ya existe");
                    conexion.CerrarConexion();
                }
                else
                {
                    conexion.CerrarConexion();

                    SqlCommand cmd = new SqlCommand("exec InsertarMarca @nombreMarca", conexion.Conectar);
                    cmd.Parameters.AddWithValue("@NombreMarca", txtNombreMarca.Text);

                    conexion.AbrirConexion();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show("Marca Ingresada");
                            txtNombreMarca.Text = "";
                            conexion.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("Error ingresar Datos");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error base de datos: \n" + ex.Message);
                    }
                }
          
            }
            else
            {
                MessageBox.Show("Campo Vacio");
            }
            mostrarLista();
        }

        void mostrarLista()
        {
            SqlCommand cmd = new SqlCommand("exec MostrarMarca", conexion.Conectar);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        } 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoMarca.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec DeleteMarca @idMarca", conexion.Conectar);
                cmd.Parameters.AddWithValue("@idMarca", txtCodigoMarca.Text);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Marca Borrada");
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Error borrar marca");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Vacios \n" + ex.Message);
                }
                mostrarLista();
            }
            else
            {
                MessageBox.Show("Codigo Marca Vacio");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigoMarca.Text != "" && txtNombreMarca.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec UpdateMarca @idMarca, @nombreMarca", conexion.Conectar);
                cmd.Parameters.AddWithValue("@idMarca", txtCodigoMarca.Text);
                cmd.Parameters.AddWithValue("@nombreMarca", txtNombreMarca.Text);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Marca Actualizada");
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Error actualizar marca");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Vacios \n" + ex.Message);
                }
                mostrarLista();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoMarca.Clear();
            txtNombreMarca.Clear();
            txtBuscarMarca.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                txtCodigoMarca.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtNombreMarca.Text = dataGridViewRow.Cells[1].Value.ToString();
            }
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sd = new SqlCommand("select idMarca as 'Codigo Marca', nombreMarca as 'Nombre Marca' from Marca where nombreMarca like '%" + txtBuscarMarca.Text + "%'", conexion.Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sd;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.CerrarConexion();

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteMarca Reporte = new Reportes.FrmReporteMarca();
            Reporte.ShowDialog();
        }
    }
}
