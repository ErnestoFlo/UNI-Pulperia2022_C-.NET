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
    public partial class PerfilUsuario : Form
    {
        public string username;

        public PerfilUsuario()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
       
        public void contraUsuario()
        {
            conexion.AbrirConexion();
            //extraer contraseña desencriptada
            SqlCommand cmd1 = new SqlCommand("exec ContraseñaUsuario @idUsuario", conexion.Conectar);
            cmd1.Parameters.AddWithValue("@idUsuario",txtId.Text);
            SqlDataReader lector1 = cmd1.ExecuteReader();

            if (lector1.Read())
            {
                txtcontra.Text = Convert.ToString(lector1[0]);
            }
            conexion.CerrarConexion();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
  
            conexion.AbrirConexion();

            //extraer informacion del usuario a editar
            SqlCommand cmd = new SqlCommand("exec usuarioPorUsername @user", conexion.Conectar);
            cmd.Parameters.AddWithValue("@user", username);

            try
            {
                SqlDataReader lector = cmd.ExecuteReader();
                

                if (lector.Read())
                {
                    txtId.Text = Convert.ToString(lector[0]);
                    txtusuario.Text = Convert.ToString(lector[1]);
                    txtnombre.Text = Convert.ToString(lector[3]);
                    txtapellido.Text = Convert.ToString(lector[4]);
                    txtcorreo.Text = Convert.ToString(lector[5]);
                    txttelefono.Text = Convert.ToString(lector[6]);
                }
                conexion.CerrarConexion();

                contraUsuario();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontra.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && txtcorreo.Text != "" && txttelefono.Text != "")
            {

                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("exec actualizarUsuario @idUsuario, @user, @contra, @nombre, @apellido, @correo, @telefono", conexion.Conectar);
                cmd.Parameters.AddWithValue("@idUsuario", txtId.Text);
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
                        MessageBox.Show("Usuario actualizado satisfactoriamente");
                        conexion.CerrarConexion();
                        ListadoUsuarios usuarios = new ListadoUsuarios();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los  Datos");
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
            frmMenuPrincipal menu = new frmMenuPrincipal();
            this.Hide();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.White;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.FromArgb(32, 43, 76);
        }
    }
}

