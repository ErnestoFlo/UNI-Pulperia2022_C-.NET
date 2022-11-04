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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ingrese ID", "Eliminar Usuario");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
        }

        private void btnAgregarEditar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontra.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && txtcorreo.Text != "" && txttelefono.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec Crearusuario @user, @contra, @nombre, @apellido, @correo, @telefono", conexion.Conectar);
                cmd.Parameters.AddWithValue("@user", txtusuario.Text);
                cmd.Parameters.AddWithValue("@contra", txtcontra.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@apellido", txtapellido.Text);
                cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Usuario Ingresado");
                        txtusuario.Text = "";
                        txtcontra.Text = "";
                        txtnombre.Text = "";
                        txtapellido.Text = "";
                        txtcorreo.Text = "";
                        txttelefono.Text = "";
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar Datos");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la base de datos: \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese Todos los campos");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ListadoUsuarios usuarios = new ListadoUsuarios();
            usuarios.Show();
        }
    }
}
/*
 if (txtusuario.Text != "" && txtcontra.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && txtcorreo.Text != "" && txttelefono.Text != "")
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec actualizarUsuario @idUsuario, @user, @contra, @nombre, @apellido, @correo, @telefono", conexion.Conectar);
                cmd.Parameters.AddWithValue("@idUsuario", txtid.Text);
                cmd.Parameters.AddWithValue("@user", txtusuario.Text);
                cmd.Parameters.AddWithValue("@contra", txtcontra.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@apellido", txtapellido.Text);
                cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Usuario Ingresado");
                        txtusuario.Text = "";
                        txtcontra.Text = "";
                        txtnombre.Text = "";
                        txtapellido.Text = "";
                        txtcorreo.Text = "";
                        txttelefono.Text = "";
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar Datos");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la base de datos: \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese Todos los campos");
            }
 */